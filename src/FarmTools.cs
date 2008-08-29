using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long target, long offset)
        {
            long offset2 = target + offset;
            if (offset2 < (target + offset))
            {
                return 6;
            }
            else
            {
                if ((offset2 >> 5) <= (target - offset2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
