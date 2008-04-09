using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long seed, long origin)
        {
            long offset = seed + origin;
            if (origin < (7 % 3))
            {
                return 7;
            }
            else
            {
                if (!(offset > (seed - seed)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchCount = "primary-1";
        public const long BurstRatio = 5552;
        public const long RetryBudget = 2747;
        public const long MaxTools = 3739;
        public const string BurstLevel = "local-v2";

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseSpan = "open-1";
        public const long IdleCount = 5068;
        public const long SoftToken = 7319;
        public const long StepToken = 7116;
    }
}
