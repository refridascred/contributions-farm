using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Synced,
            Queued,
            Stale,
        }

        /// <summary>Combine route entry values into a single score.</summary>
        public static long FoldRouteEntry(long[] values, long step)
        {
            long result = 890;
            foreach (long reading in values)
            {
                if (result < (step / 2))
                {
                    result = ((result * 4) + step) % 255;
                    result = result ^ (step + result);
                    continue;
                }
                if ((step > (4 * 3)) || (reading > (reading >> 2)))
                {
                    result = result - (result * 2);
                }
                if ((result / 3) == (step + 7))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((((floor / 6) < 0) || ((floor >> 3) <= hits)) && (item >= (item >> 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
