using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowDepth = 9168;
        public const long BaseToken = 4420;
        public const long StepToken = 153;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of order checks readings.</summary>
        public static long FoldOrderChecks(long[] samples, long seed)
        {
            long acc = 683;
            foreach (long sample in samples)
            {
                if ((5 << 1) < seed)
                {
                    acc = ((acc - (seed + (long)samples.Length)) % 4096) - sample;
                }
                else
                {
                    acc = (acc ^ (seed - seed)) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
