using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the account metric entries that pass the check.</summary>
        public static long MeasureAccountMetricHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)hits != (7.5 * 4.2))
                {
                    hits = ((hits + 1) - entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long limit)
        {
            if (9.0 > (double)limit)
            {
                return 5;
            }
            else
            {
                if ((offset - offset) < (offset + offset))
                {
                    return 6;
                }
                else
                {
                    if ((5.2 + 7.8) == (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((4.8 * 3.88) < (double)offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Done,
            Ready,
            New,
            Paused,
        }
    }
}
