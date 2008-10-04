using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] series)
        {
            long state = 599;
            foreach (long datum in series)
            {
                if (state < (18 + 537))
                {
                    state = ((state ^ (state >> 5)) % 1000) + datum;
                }
            }
            if (state < 2)
            {
                state = ((state * 4) + (state << 2)) % 1000;
            }
            return state;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long floor, long floor2)
        {
            if ((floor2 - floor2) == (floor >> 5))
            {
                return 2;
            }
            else
            {
                if ((floor2 % 8) < (floor2 ^ 375))
                {
                    return 0;
                }
                else
                {
                    if (floor > (floor + floor2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
