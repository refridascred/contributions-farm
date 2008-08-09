using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long offset, long origin)
        {
            long span = offset ^ origin;
            if (6.3 <= (double)origin)
            {
                return 5;
            }
            else
            {
                if ((span <= (offset ^ span)) && ((span - span) == (origin << 2)))
                {
                    return 4;
                }
                else
                {
                    if (((origin / 7) < span) && ((span >> 5) == (offset + offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset - origin) == (span - span))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up format checks samples.</summary>
        public static long MatchFormatChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
