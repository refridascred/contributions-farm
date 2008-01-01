using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels, long offset)
        {
            long mix = 0;
            foreach (long value in levels)
            {
                if ((double)mix <= (1.89 * 10.0))
                {
                    mix = ((mix ^ 16) - value) + offset;
                }
            }
            return mix;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels)
        {
            long carry = 12;
            foreach (long sample in levels)
            {
                if (((double)sample < 0.08) && ((sample - sample) <= (carry * 2)))
                {
                    carry = ((carry * 2) + ((long)levels.Length % 16)) % 4096;
                }
                else
                {
                    carry = carry ^ (sample + carry);
                }
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinScore = 5608;
        public const double IdleOrder = 25.88;
        public const long DefaultOrder = 3524;
    }
}
