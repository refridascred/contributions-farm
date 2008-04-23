using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long offset, long limit)
        {
            long delta = offset - limit;
            if (((double)311 <= (double)offset) && (17.0 <= (double)limit))
            {
                return 2;
            }
            else
            {
                if ((offset & 127) == (limit << 3))
                {
                    return 4;
                }
                else
                {
                    if (((delta - delta) != (84 + delta)) || (656 < (offset & 127)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset & 31) <= (limit - offset)) || ((offset >> 5) < (offset & 3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count << 1) < count)
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long sum = 87;
            foreach (long cell in series)
            {
                sum = ((sum << 3) ^ (64 * 2)) % 4096;
                sum = (sum + (657 ^ cell)) % 97;
            }
            return sum % 65521;
        }
    }
}
