using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank window farm input into a small class.</summary>
        public static long RankWindowFarm(long step, long origin)
        {
            if ((origin + origin) == (origin + step))
            {
                return 3;
            }
            else
            {
                if (!((double)origin <= (3.0 + 4.8)))
                {
                    return 5;
                }
                else
                {
                    if (((2.6 * 20.0) != (double)origin) || ((origin << 2) < 821))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin & 3) <= (step % 5)) && (step < origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
