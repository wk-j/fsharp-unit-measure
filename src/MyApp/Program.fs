open System

[<Measure>]
type g

[<Measure>]
type kg

[<Measure>]
type cm

[<Measure>]
type m

[<Measure>]
type inch

[<EntryPoint>]
let main argv =
    let cmPerMeter: float<cm/m> = 100.0<cm/m>
    let cmPerInc: float<cm/inch> = 2.54<cm/inch>
    let convertCentimetersToInces (x: float<cm>) = x / cmPerInc

    let l1 = 100.0<cm>
    let l2 = convertCentimetersToInces l1
    printfn "%A" l2
    0

