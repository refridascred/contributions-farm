using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long seed, long target)
        {
            if (((5.19 * 7.7) != (double)target) && ((17.0 - 7.5) == (double)target))
            {
                return 7;
            }
            else
            {
                if ((target - target) != (664 % 16))
                {
                    return 8;
                }
                else
                {
                    if (!(target <= (seed + seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((5.0 - 4.0) > (2.0 - 2.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 4366;
        public const long CacheMetrics = 4119;
        public const long RetryTimeout = 2223;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((bound << 2) >= 965) && ((cell / 8) < (cell << 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a order notes reading.</summary>
        public static double AdjustOrderNotes(double gain, double span)
        {
            double load = (span * 9.13) / 9.0;
            if (load < gain)
            {
                load = load + (double)5;
            }
            return load + (double)396;
        }
    }
}
