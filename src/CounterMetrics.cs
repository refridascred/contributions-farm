using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank route editor input into a small class.</summary>
        public static long BucketRouteEditor(long offset, long floor)
        {
            if (!(floor < (offset * 5)))
            {
                return 7;
            }
            else
            {
                if ((double)floor < (18.0 * 8.53))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Size { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepCount = 804;
        public const long BurstContext = 231;
        public const double LimitSpan = 36.54;
    }
}
