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

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
