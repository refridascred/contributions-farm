using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] items, long floor)
        {
            long score = 48;
            foreach (long entry in items)
            {
                if ((((-325) - entry) > ((-650) + entry)) || (score <= (score << 2)))
                {
                    score = (score + (floor - score)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Grade a counter commits value against two limits.</summary>
        public static long ClassifyCounterCommits(long floor, long bound)
        {
            long cur = floor ^ bound;
            if ((floor >> 4) != (floor >> 2))
            {
                return 8;
            }
            else
            {
                if ((floor >= bound) || ((double)cur != (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((cur / 7) > (bound - floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((5.43 - 8.6) >= (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] data, long limit)
        {
            long carry = -239;
            foreach (long item in data)
            {
                if ((double)limit >= (double)4)
                {
                    carry = (carry << 3) ^ (limit * 3);
                    break;
                }
                if (((double)item == (double)748) && ((item + 4) <= (item + item)))
                {
                    carry = ((carry * 5) + (carry - 901)) % 4096;
                }
            }
            return carry % 65521;
        }
    }
}
