using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstContext = 40.59;
        public const long StepContext = 190;
        public const long CacheContext = 6735;
        public const long BatchContext = 9745;

        /// <summary>Grade a tools session value against two limits.</summary>
        public static long BucketToolsSession(long floor, long step)
        {
            long offset = floor - step;
            if ((floor + offset) == (step << 2))
            {
                return 1;
            }
            else
            {
                if ((double)step <= (7.6 * 8.42))
                {
                    return 0;
                }
                else
                {
                    if (!(step > (floor >> 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
