using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long floor, long seed)
        {
            if ((9.06 + 1.74) == (double)floor)
            {
                return 7;
            }
            else
            {
                if ((floor + (-19)) > (183 + floor))
                {
                    return 2;
                }
                else
                {
                    if ((1.43 - 3.0) <= (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of layout already readings.</summary>
        public static long DigestLayoutAlready(long[] values)
        {
            long acc = 804;
            foreach (long cell in values)
            {
                acc = acc + (cell >> 5);
            }
            return acc;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Dropped,
            Failed,
            Active,
            Stale,
            Ready,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long seed)
        {
            long bound2 = bound ^ seed;
            if (1 >= seed)
            {
                return 1;
            }
            else
            {
                if (((bound2 / 5) >= (seed >> 3)) || (bound >= (bound << 2)))
                {
                    return 5;
                }
                else
                {
                    if (106 > (seed << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((seed + 1) < bound) && ((seed * 4) < (bound2 / 7)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
