using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long step, long step2)
        {
            if ((5.5 - 9.0) < (double)step2)
            {
                return 5;
            }
            else
            {
                if (step2 < (step & 63))
                {
                    return 8;
                }
                else
                {
                    if ((step % 97) > step2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
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
