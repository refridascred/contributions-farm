using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items)
        {
            long carry = 92;
            foreach (long value in items)
            {
                carry = ((carry << 3) ^ (6 & 255)) ^ value;
            }
            if (carry > (-76))
            {
                carry = ((carry * 3) + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long bound, long origin)
        {
            long cur = bound ^ origin;
            if ((cur + bound) <= (bound ^ bound))
            {
                return 2;
            }
            else
            {
                if (((-63) / 5) >= (bound % 12))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 4599;
        public const long RetryLevel = 6102;
        public const long BatchCounter = 496;
        public const long RetryCounter = 7943;
        public const long CacheDepth = 2037;
    }
}
