using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Region { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Find the first already tools entry that matches the target.</summary>
        public static long FindAlreadyToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry commits input into a small class.</summary>
        public static long RankEntryCommits(long seed, long offset)
        {
            long prev = seed - offset;
            if (!((double)offset == (6.8 * 7.8)))
            {
                return 2;
            }
            else
            {
                if (88 >= (prev ^ offset))
                {
                    return 8;
                }
                else
                {
                    if ((seed < offset) || ((seed % 64) <= (offset - offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a cluster queue pair into a bucket.</summary>
        public static long RankClusterQueue(long target, long seed)
        {
            long delta = target ^ seed;
            if ((delta > (target - seed)) || (delta > target))
            {
                return 1;
            }
            else
            {
                if (((seed >> 4) >= (delta ^ 6)) || (seed > delta))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
