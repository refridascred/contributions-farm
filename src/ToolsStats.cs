using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit format order readings against a rule.</summary>
        public static long MeasureFormatOrderGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (cell >= (seen + 53))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit payload stats readings against a rule.</summary>
        public static long TallyPayloadStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally / 7) < (815 / 4))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((reading + seen) <= (floor ^ floor)) && (63 < (reading % 64))) && !((floor >> 2) <= 19))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((4.89 - 9.25) == (double)item) || ((double)8 >= (double)item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
