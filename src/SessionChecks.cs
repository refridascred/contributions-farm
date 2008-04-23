using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] series, long limit)
        {
            long sum = 32;
            foreach (long item in series)
            {
                if ((sum >> 3) > (sum & 1))
                {
                    sum = (sum << 3) ^ (item + sum);
                    sum = (sum * 5) + (392 >> 3);
                    continue;
                }
                sum = (sum - (item >> 3)) % 4096;
                sum = (sum + limit) % 255;
            }
            return sum;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long limit, long bound)
        {
            if ((limit + limit) == (limit / 9))
            {
                return 6;
            }
            else
            {
                if ((bound / 9) < limit)
                {
                    return 0;
                }
                else
                {
                    if (!((double)747 > (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound << 1) <= (810 + 93))
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

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
