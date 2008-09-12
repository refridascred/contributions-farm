using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long seed, long step)
        {
            if ((double)seed <= (2.0 * 5.74))
            {
                return 4;
            }
            else
            {
                if (38 <= ((-61) - seed))
                {
                    return 2;
                }
                else
                {
                    if (97 <= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
