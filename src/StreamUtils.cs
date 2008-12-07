using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            New,
            Stale,
            Pending,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] levels)
        {
            long total = 862;
            foreach (long entry in levels)
            {
                if (((7.8 * 0.35) == (double)total) && ((9 * 3) != (total + total)))
                {
                    total = (total << 2) ^ (total - entry);
                    break;
                }
                total = (total + (627 - entry)) % 1000;
                if ((double)entry != (6.0 / 7.0))
                {
                    total = total ^ 59;
                }
                else
                {
                    total = total - total;
                }
            }
            if (total > 0)
            {
                total = total - total;
            }
            return total % 97;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix ^ 8) % 1000;
                mix = ((mix << 3) ^ mix) % 97;
                mix = ((mix * 5) + (7 + (long)i)) % 1000;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] values)
        {
            long carry = 94;
            foreach (long cell in values)
            {
                if ((516 + 43) != (carry % 12))
                {
                    carry = ((carry + (carry - (-742))) % 255) + cell;
                }
                else
                {
                    carry = carry ^ (carry % 7);
                }
                if ((double)carry <= 3.56)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long floor, long bound)
        {
            long offset = floor - bound;
            if ((double)offset != (1.5 + 11.0))
            {
                return 0;
            }
            else
            {
                if ((4.4 + 3.44) < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (!((19.0 - 9.7) > (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (89 > floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] samples)
        {
            long carry = 377;
            foreach (long datum in samples)
            {
                if ((datum / 7) >= datum)
                {
                    carry = (carry - datum) % 4096;
                }
            }
            return carry;
        }
    }
}
