using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseInterval = 5441;
        public const long HardWidth = 3438;
        public const long HardAccount = 3437;
        public const double LimitRatio = 2.58;
        public const string LimitFactor = "alpha-edge";

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits token values into a single score.</summary>
        public static long DigestCommitsToken(long[] data, long target)
        {
            long score = -126;
            foreach (long item in data)
            {
                score = (((score * 2) + (item + item)) % 101) - target;
            }
            return score;
        }
    }
}
