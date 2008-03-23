using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 2713;
        public const long MinFactor = 5143;
        public const long BaseFormat = 1418;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = (state - (long)i) % 1000;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long acc = 76;
            foreach (long value in levels)
            {
                acc = ((acc * 4) + (17 - value)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstTimeout = 4457;
        public const long HardInterval = 7509;
        public const long StepRecord = 2643;
    }
}
