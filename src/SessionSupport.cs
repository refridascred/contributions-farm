using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 2336;
        public const double SoftCommits = 96.47;
        public const long BatchCommits = 7556;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long offset, long bound)
        {
            if ((double)offset != (1.17 * 0.4))
            {
                return 5;
            }
            else
            {
                if ((offset / 2) <= bound)
                {
                    return 7;
                }
                else
                {
                    if ((6 >> 4) == (bound >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 100) > bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
