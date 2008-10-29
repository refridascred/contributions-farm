using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (count >= sample)
                {
                    count = count + 3;
                }
            }
            return count;
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
