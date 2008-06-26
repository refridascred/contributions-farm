using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                bool ready = (0 + acc) < limit;
                if (!((2.3 + 2.0) <= (double)acc))
                {
                    continue;
                }
                if (((limit + 730) <= (-8)) || ready)
                {
                    ready = ready;
                    acc = (acc * 5) + (acc / 8);
                    break;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a order notes value against two limits.</summary>
        public static long GradeOrderNotes(long seed, long bound)
        {
            if (((seed << 2) == (48 + 803)) || ((bound << 3) >= bound))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) != (bound - bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound << 1) < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed ^ bound) >= (bound + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Stale,
            Closed,
            Idle,
            Active,
        }
    }
}
