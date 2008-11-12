using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long limit, long seed)
        {
            long offset = limit ^ seed;
            if ((seed << 2) >= (seed ^ limit))
            {
                return 4;
            }
            else
            {
                if (((offset / 7) != (seed % 12)) || ((limit + limit) <= (offset ^ 6)))
                {
                    return 0;
                }
                else
                {
                    if ((seed < (395 / 4)) && ((offset / 2) >= limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset + limit) >= (offset ^ limit)) || ((offset + offset) >= offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] readings, long seed)
        {
            long total = 0;
            foreach (long value in readings)
            {
                total = ((total - total) % 97) + value;
                if (!((total * 5) <= seed))
                {
                    total = (total * 2) + 92;
                }
            }
            return total;
        }
    }
}
