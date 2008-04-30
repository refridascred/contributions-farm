using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftBudget = 93.48;
        public const long MaxSession = 8906;
        public const double HardRatio = 87.01;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen + 916) > seen)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }
    }
}
