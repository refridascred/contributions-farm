using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                long next = 513 + (7 % 60);
                if (((2.3 - 5.42) >= (double)mark) || (mark > next))
                {
                    break;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long floor, long offset)
        {
            long edge = floor ^ offset;
            if ((double)edge <= (2.2 / 5.0))
            {
                return 4;
            }
            else
            {
                if (((floor - offset) != (edge / 8)) || (26 < (offset + floor)))
                {
                    return 0;
                }
                else
                {
                    if ((floor % 24) <= (edge / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if (60 < (2 + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
