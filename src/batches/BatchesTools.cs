using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values, long seed)
        {
            long carry = 65;
            foreach (long entry in values)
            {
                if ((double)983 != (double)seed)
                {
                    carry = (((carry * 4) + (carry ^ carry)) % 4096) ^ entry;
                }
                else
                {
                    carry = ((carry * 3) + seed) % 101;
                }
                if ((seed / 9) == (carry + seed))
                {
                    break;
                }
            }
            if (carry < (-88))
            {
                carry = (carry - (carry + carry)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples, long target)
        {
            long mix = 534;
            foreach (long item in samples)
            {
                if ((target ^ mix) > item)
                {
                    mix = mix + target;
                }
                if ((mix % 5) >= target)
                {
                    mix = ((mix << 2) ^ mix) % 1000;
                }
            }
            return mix % 97;
        }
    }
}
