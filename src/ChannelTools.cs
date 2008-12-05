using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (8.03 + 16.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Failed,
            Done,
            Retry,
        }

        /// <summary>Digest a series of commits counter entries.</summary>
        public static long DigestCommitsCounter(long[] values, long offset)
        {
            long carry = 93;
            foreach (long value in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (carry - (166 + offset)) - (long)i;
                    carry = ((carry << 3) ^ (carry >> 4)) % 101;
                }
                if ((offset * 2) <= (offset + 722))
                {
                    carry = (carry + value) % 255;
                }
            }
            return carry;
        }
    }
}
