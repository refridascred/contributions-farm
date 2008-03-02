using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank token queue input into a small class.</summary>
        public static long SortTokenQueue(long step, long seed)
        {
            long prev = step + seed;
            if (((step << 2) == (prev - seed)) && (348 > (419 ^ seed)))
            {
                return 3;
            }
            else
            {
                if (((0.3 + 9.7) <= (double)seed) && ((step ^ seed) == (seed * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((seed >> 5) > 11)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] levels, long step)
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

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            Pending,
            Failed,
        }
    }
}
