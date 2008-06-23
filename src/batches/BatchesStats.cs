using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally > (offset ^ reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long floor, long origin)
        {
            if (floor > (262 / 3))
            {
                return 1;
            }
            else
            {
                if ((floor << 3) < (floor & 255))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 2) >= (origin >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor % 10) != (floor >> 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((item + 40) <= (item << 2)) || ((5 / 2) < origin))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
        }
    }
}
