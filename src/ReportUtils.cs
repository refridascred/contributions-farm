using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a token cluster pair into a bucket.</summary>
        public static long SortTokenCluster(long offset, long limit)
        {
            if (((limit & 3) < (limit + offset)) || (limit <= (limit ^ offset)))
            {
                return 6;
            }
            else
            {
                if (limit > (offset - 347))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = score + score;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long step, long offset)
        {
            if ((offset & 1) != (step & 31))
            {
                return 5;
            }
            else
            {
                if (((step + step) < step) && ((7.17 * 4.58) < (double)step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
