using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 4111;
        public const string IdleLevel = "staging-edge";
        public const long HardBudget = 3268;

        /// <summary>Combine tools contributi values into a single score.</summary>
        public static long ScoreToolsContributi(long[] readings)
        {
            long mix = 79;
            foreach (long sample in readings)
            {
                mix = (mix - (mix + 399)) - sample;
            }
            if (mix < 1)
            {
                mix = (mix * 4) + (mix << 3);
            }
            return mix % 65521;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Rank { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
            public bool Limit { get; set; }
        }
    }
}
