using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples, long target)
        {
            long state = 575;
            foreach (long item in samples)
            {
                state = ((state << 2) ^ state) % 65521;
                if (item > (target / 3))
                {
                    state = (state ^ (-576)) % 97;
                }
                else
                {
                    state = state - (64 >> 3);
                }
            }
            if (state < 6)
            {
                state = (state - (state - state)) % 1000;
            }
            return state;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long bound)
        {
            long bound2 = offset - bound;
            if ((bound & 7) == (offset + (-4)))
            {
                return 7;
            }
            else
            {
                if ((bound2 % 5) == (offset - bound2))
                {
                    return 8;
                }
                else
                {
                    if (!(bound2 >= (offset << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset >= (bound + bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long limit, long limit2)
        {
            long delta = limit - limit2;
            if (delta <= (delta % 16))
            {
                return 1;
            }
            else
            {
                if ((limit >> 2) > (limit >> 3))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
