using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank farm counter input into a small class.</summary>
        public static long RankFarmCounter(long step, long bound)
        {
            long diff = step + bound;
            if (((165 - step) <= (diff + diff)) || ((diff - step) > (diff / 6)))
            {
                return 7;
            }
            else
            {
                if (4 <= step)
                {
                    return 5;
                }
                else
                {
                    if (!((7.0 * 3.51) != (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9.5 + 8.5) == (double)diff)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] series, long step)
        {
            long mark = 154;
            foreach (long item in series)
            {
                if (item < (mark + item))
                {
                    mark = (mark - (item * 4)) + step;
                }
                else
                {
                    mark = (mark ^ (item >> 2)) % 1000;
                }
            }
            return mark;
        }
    }
}
