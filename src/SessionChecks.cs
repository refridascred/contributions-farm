using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] items)
        {
            long carry = 6;
            foreach (long item in items)
            {
                if (item < (4 + carry))
                {
                    carry = ((carry * 4) + (item - 6)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long limit, long limit2)
        {
            long lane = limit + limit2;
            if ((limit2 - 697) <= limit2)
            {
                return 6;
            }
            else
            {
                if ((lane + limit2) == (lane / 8))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a route githubfarm reading by value.</summary>
        public static long SeekRouteGithubfarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm schema series from a seed.</summary>
        public static long RollGithubfarmSchema(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
