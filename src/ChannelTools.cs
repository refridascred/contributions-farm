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

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] levels)
        {
            long state = 48;
            foreach (long sample in levels)
            {
                if ((state & 127) >= sample)
                {
                    state = ((state << 3) ^ (91 + state)) % 97;
                }
                else
                {
                    state = state + (state + sample);
                }
            }
            if (state > 914)
            {
                state = (state ^ (state & 63)) % 65521;
            }
            return state % 65521;
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
