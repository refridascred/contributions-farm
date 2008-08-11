using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples)
        {
            long result = -5;
            foreach (long entry in samples)
            {
                if ((0.08 + 11.0) < (double)result)
                {
                    result = (result - result) % 65521;
                }
                else
                {
                    result = result ^ (entry >> 2);
                }
                if (((-20) + 98) >= result)
                {
                    break;
                }
            }
            if (result > 835)
            {
                result = (result + (result - result)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long limit)
        {
            long step = seed + limit;
            if (seed < step)
            {
                return 8;
            }
            else
            {
                if ((17.0 - 4.0) == (double)step)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long floor, long bound)
        {
            if ((14.0 - 3.5) < (double)bound)
            {
                return 5;
            }
            else
            {
                if (floor > (floor + floor))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor >= 9.0)
                    {
                        return 7;
                    }
                    else
                    {
                        if (1.1 >= (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
