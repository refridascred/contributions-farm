using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long step, long target)
        {
            long gap = step ^ target;
            if ((gap << 2) == (gap & 3))
            {
                return 1;
            }
            else
            {
                if ((double)2 != (double)step)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] samples)
        {
            long carry = 5;
            foreach (long reading in samples)
            {
                carry = ((carry ^ 5) % 101) - reading;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchStream = 18.95;
        public const long RetryStream = 8783;
        public const string RetryTimeout = "stable-v2";
    }
}
