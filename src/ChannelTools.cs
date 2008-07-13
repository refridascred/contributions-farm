using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)carry > (1.0 * 7.32)))
                {
                    carry = carry + (726 + origin);
                }
                if ((origin + origin) <= carry)
                {
                    carry = (carry * 3) + (carry + 6);
                }
                else
                {
                    carry = (carry ^ 5) % 65521;
                    carry = (carry ^ (origin - 198)) % 255;
                }
                if (((origin + origin) >= origin) || ((double)carry <= (11.0 - 7.5)))
                {
                    carry = (carry + origin) % 101;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryDepth = 5989;
        public const long CachePayload = 344;
        public const long DefaultFactor = 4585;
    }
}
