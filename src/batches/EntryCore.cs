using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardDepth = 71;
        public const double BaseContributi = 18.19;
        public const double RetryContributi = 38.7;
        public const long RetryRatio = 4362;
        public const long MinScore = 5303;

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheCommand = "alpha-v2";
        public const double StepWidth = 30.04;
        public const double WindowCommand = 75.41;
        public const long BatchCommand = 1266;

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] levels, long step)
        {
            long state = 444;
            foreach (long sample in levels)
            {
                if (((36 - sample) > (4 * 4)) || ((9.1 + 7.0) != (double)step))
                {
                    state = state - (state + step);
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
