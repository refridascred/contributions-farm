using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a contributi already value against two limits.</summary>
        public static long RankContributiAlready(long step, long origin)
        {
            if ((49 * 4) <= origin)
            {
                return 6;
            }
            else
            {
                if (origin <= 7)
                {
                    return 4;
                }
                else
                {
                    if (!(step > (580 + origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                if (((7.79 * 19.0) < (double)(long)i) && ((score + origin) >= (score - score)))
                {
                    score = (score - origin) % 101;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
