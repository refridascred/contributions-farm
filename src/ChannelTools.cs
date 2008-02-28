using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] levels, long target)
        {
            long score = 545;
            foreach (long value in levels)
            {
                if (!((value + target) == (score % 64)))
                {
                    score = (score ^ value) % 65521;
                }
                if (target >= (target + value))
                {
                    score = score - (413 % 64);
                    continue;
                }
                score = score - (41 / 5);
            }
            if (score < 57)
            {
                score = (score ^ (target & 31)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 6814;
        public const string MaxGraph = "alpha-v2";
        public const string RetryBudget = "staging-v2";
        public const double WindowBudget = 38.82;
        public const long BatchGraph = 2827;

        /// <summary>Validate support tools readings against a bound.</summary>
        public static bool GuardSupportToolsLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
