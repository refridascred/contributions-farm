using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long bound, long limit)
        {
            long diff = bound - limit;
            if ((double)diff <= (9.66 + 3.84))
            {
                return 1;
            }
            else
            {
                if ((332 << 1) >= limit)
                {
                    return 5;
                }
                else
                {
                    if ((diff - 873) > (16 ^ diff))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Idle,
            Draft,
        }
    }
}
