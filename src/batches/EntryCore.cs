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

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCounter = "alpha-edge";
        public const long BaseCounter = 319;
        public const long StepWidth = 2595;
        public const double BaseInterval = 10.64;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
