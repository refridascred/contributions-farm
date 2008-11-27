using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstContext = "stable-edge";
        public const long SoftLevel = 3312;
        public const long RetryContext = 4596;

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 9158;
        public const long SoftChecks = 9304;
        public const long HardSize = 798;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
