using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double weight, double floor)
        {
            double load = (4.18 / 3.0) - 9.88;
            if (load > (0.1 + 6.6))
            {
                load = (load + (floor * 0.16)) + weight;
            }
            return load - (double)27;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long limit, long origin)
        {
            if ((4 / 9) < (origin << 2))
            {
                return 5;
            }
            else
            {
                if (!((7.5 - 9.0) != (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((origin * 5) != (1 & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route profile input into a small class.</summary>
        public static long GradeRouteProfile(long limit, long bound)
        {
            if ((bound % 97) > (limit >> 3))
            {
                return 5;
            }
            else
            {
                if ((double)limit <= (double)42)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up queue route samples.</summary>
        public static long MatchQueueRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
