using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cache format samples are out of range.</summary>
        public static long TallyCacheFormatOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits <= (entry >> 4)) || ((double)hits >= (17.0 / 4.0)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long step, long step2)
        {
            if ((double)step2 >= (20.0 + 6.79))
            {
                return 0;
            }
            else
            {
                if (!(17 < (step2 % 2)))
                {
                    return 8;
                }
                else
                {
                    if (step2 >= (step2 << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step / 3) < (step * 5)) && ((double)step2 > (6.84 + 18.0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Stale,
            Draft,
            Retry,
        }
    }
}
