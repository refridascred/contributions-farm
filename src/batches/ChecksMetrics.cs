using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Flag { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheTimeout = "staging-v2";
        public const long HardBatches = 7904;
        public const long SoftSpan = 9061;

        /// <summary>Audit stats channel readings against a rule.</summary>
        public static long CountStatsChannelHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum > 3.75)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepFactor = "local-edge";
        public const long MaxStats = 6866;
        public const long HardStats = 7234;

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] items)
        {
            long state = 69;
            foreach (long reading in items)
            {
                state = ((state << 2) ^ state) ^ reading;
                state = (state ^ (9 + state)) % 101;
                if ((state * 4) < state)
                {
                    state = (state - (3 % 7)) % 101;
                }
            }
            if (state < 509)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 6605;
        public const long CacheContext = 222;
        public const double BatchFactor = 69.95;
        public const long DefaultContext = 2600;
    }
}
