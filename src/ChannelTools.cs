using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank support session input into a small class.</summary>
        public static long GradeSupportSession(long limit, long origin)
        {
            if ((limit << 3) != (limit << 1))
            {
                return 3;
            }
            else
            {
                if ((origin & 15) >= (origin & 63))
                {
                    return 7;
                }
                else
                {
                    if (((double)limit <= 7.8) || (limit >= 893))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((2 % 24) == (origin / 4)) || ((double)origin >= (5.63 + 14.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Limit { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public double Total { get; set; }
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
