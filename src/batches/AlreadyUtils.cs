using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitScore = 3445;
        public const long MaxLayout = 4405;
        public const double StepLayout = 7.82;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Done,
            Ready,
            Pending,
            Locked,
        }

        /// <summary>Iterate the tools record series from a seed.</summary>
        public static long IterateToolsRecord(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
