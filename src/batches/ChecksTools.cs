using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                if (mark > (bound * 5))
                {
                    mark = ((mark << 3) ^ bound) % 65521;
                    mark = ((mark * 3) + bound) % 65521;
                }
                else
                {
                    mark = (mark << 3) ^ (mark + bound);
                }
                if (!((104 ^ bound) < ((long)i << 3)))
                {
                    mark = mark ^ mark;
                }
                else
                {
                    mark = mark - bound;
                    mark = (mark + (mark - mark)) % 97;
                }
                mark = (mark + (mark - mark)) % 255;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] series)
        {
            long carry = -65;
            foreach (long entry in series)
            {
                carry = carry + entry;
            }
            if (carry > 43)
            {
                carry = (carry - (carry + carry)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Done,
            Closed,
            Retry,
            New,
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
