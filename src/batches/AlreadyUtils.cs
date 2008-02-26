using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long offset, long target)
        {
            if (((69 - target) < (target / 3)) && ((target >> 5) <= (target / 6)))
            {
                return 0;
            }
            else
            {
                if ((target < offset) || ((double)offset < (3.8 + 7.2)))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long bound, long bound2)
        {
            if ((bound << 2) <= (bound % 7))
            {
                return 3;
            }
            else
            {
                if (3.4 <= (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (bound < bound2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound2 << 2) >= bound2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (3.0 < (double)matches)
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long bound, long target)
        {
            long slot = bound - target;
            if ((77 & 7) == (bound % 12))
            {
                return 1;
            }
            else
            {
                if (((slot & 3) > slot) && ((4.4 / 6.0) < (double)slot))
                {
                    return 4;
                }
                else
                {
                    if (((target << 2) < (bound * 3)) && ((double)slot <= (3.0 * 1.14)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((target + slot) >= (slot + target)) && (((-149) * 5) != (slot << 1)))
                        {
                            return 0;
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
