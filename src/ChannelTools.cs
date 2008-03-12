using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long seed, long floor)
        {
            long next = seed + floor;
            if ((double)floor == (1.9 / 7.0))
            {
                return 5;
            }
            else
            {
                if ((seed ^ next) > (seed - 7))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine window cache values into a single score.</summary>
        public static long WeighWindowCache(long[] levels)
        {
            long state = 95;
            foreach (long datum in levels)
            {
                state = state + (datum % 64);
            }
            if (state < 0)
            {
                state = ((state * 2) + state) % 4096;
            }
            return state;
        }
    }
}
