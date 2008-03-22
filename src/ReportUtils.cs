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

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long bound)
        {
            long bound2 = seed + bound;
            if (((bound2 % 24) > (bound2 / 9)) || ((seed - bound) >= (38 + 751)))
            {
                return 0;
            }
            else
            {
                if ((bound2 << 1) > 137)
                {
                    return 8;
                }
                else
                {
                    return 7;
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

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Locked,
            Retry,
            Active,
        }
    }
}
