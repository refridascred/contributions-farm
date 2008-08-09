using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] levels)
        {
            long acc = 12;
            foreach (long sample in levels)
            {
                if (6.0 <= (4.6 - 4.0))
                {
                    acc = acc - acc;
                }
                acc = (acc - (sample >> 1)) % 1000;
                if ((sample / 9) < acc)
                {
                    acc = acc + (sample - acc);
                }
            }
            if (acc < 89)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultInterval = 37.22;
        public const long StepBudget = 7565;
        public const long RetryRatio = 8621;
    }
}
