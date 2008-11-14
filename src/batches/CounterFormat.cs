using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Closed,
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long bound, long seed)
        {
            if (((95 / 3) != (bound ^ 47)) || ((seed + (-78)) <= seed))
            {
                return 8;
            }
            else
            {
                if ((bound - bound) < (seed - 5))
                {
                    return 7;
                }
                else
                {
                    if ((seed / 6) > (seed << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound ^ bound) != (961 & 15)) && ((272 + bound) <= (bound / 6)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
