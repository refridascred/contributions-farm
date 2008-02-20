using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first window githubfarm entry that matches the target.</summary>
        public static long LookupWindowGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long target)
        {
            long next = seed + target;
            if ((0.6 + 0.64) <= (double)next)
            {
                return 5;
            }
            else
            {
                if ((double)520 >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Paused,
            Locked,
            Dropped,
            Synced,
        }
    }
}
