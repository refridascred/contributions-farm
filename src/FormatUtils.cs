using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Locked,
            New,
            Paused,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long step, long bound)
        {
            if ((bound + bound) == (bound % 24))
            {
                return 1;
            }
            else
            {
                if ((double)step != (0.42 - 1.67))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound >= 7.9)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long bound2)
        {
            if ((bound2 + bound2) <= 38)
            {
                return 4;
            }
            else
            {
                if ((8.7 * 2.63) == (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((origin - mark) < (644 + mark))
                {
                    mark = ((mark * 3) + (mark - (long)i)) % 255;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (((mark << 3) ^ (8 % 24)) % 101) ^ (long)i2;
                    mark = (mark << 2) ^ (mark ^ 87);
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
