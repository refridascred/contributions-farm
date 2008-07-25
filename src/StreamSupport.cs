using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long bound, long bound2)
        {
            if (bound <= bound2)
            {
                return 7;
            }
            else
            {
                if (((bound - bound) > bound) && ((8.0 + 1.1) < (double)bound2))
                {
                    return 6;
                }
                else
                {
                    if (!((bound2 << 2) == (bound2 % 97)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (8.72 <= (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstTimeout = 7857;
        public const double SoftBudget = 10.7;
        public const long MinRecord = 3754;

        /// <summary>Count the already payload entries that pass the check.</summary>
        public static long TallyAlreadyPayloadOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((4.7 * 2.0) >= (double)target)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
