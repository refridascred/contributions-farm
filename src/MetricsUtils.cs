using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardSpan = 67.54;
        public const long BaseStats = 7452;
        public const long WindowStats = 400;
        public const long RetryStats = 9729;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Grade a session metrics value against two limits.</summary>
        public static long BucketSessionMetrics(long origin, long floor)
        {
            long lane = origin + floor;
            if ((origin & 3) < (lane - floor))
            {
                return 6;
            }
            else
            {
                if (!(lane >= floor))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin <= 2.55)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
