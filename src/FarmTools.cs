using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a cache commits counter forward.</summary>
        public static long DeriveCacheCommits(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long step, long floor)
        {
            if ((floor - floor) >= floor)
            {
                return 3;
            }
            else
            {
                if (!((step * 3) > floor))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor >= (6.1 - 2.7))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)step >= (1.8 * 2.4)) || ((0.34 - 17.0) < (double)floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Active,
            Draft,
            Stale,
            Retry,
            Synced,
        }
    }
}
