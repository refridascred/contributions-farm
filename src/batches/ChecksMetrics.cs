using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Retry,
            Ready,
            Done,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long target, long bound)
        {
            long diff = target - bound;
            if ((double)target > (9.0 / 2.0))
            {
                return 5;
            }
            else
            {
                if (diff >= bound)
                {
                    return 7;
                }
                else
                {
                    if ((double)target > (4.3 - 2.4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value + matches) < matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Paused,
            New,
            Active,
            Pending,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long floor, long floor2)
        {
            long lane = floor ^ floor2;
            if (((double)floor2 <= 6.4) && ((double)lane != (6.0 + 4.0)))
            {
                return 8;
            }
            else
            {
                if (floor2 > (773 & 127))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowInterval = 7545;
        public const long MaxCounter = 1447;
        public const long DefaultRatio = 2645;
    }
}
