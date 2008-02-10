using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a support buffer value against two limits.</summary>
        public static long BucketSupportBuffer(long target, long target2)
        {
            long step = target + target2;
            if ((double)target < (double)target2)
            {
                return 6;
            }
            else
            {
                if (!(19 <= target))
                {
                    return 4;
                }
                else
                {
                    if ((target - target2) >= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] series, long step)
        {
            long state = 259;
            foreach (long item in series)
            {
                if (((7.0 - 3.2) < (double)state) && ((step + 83) > item))
                {
                    state = state + (step + step);
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many commits route samples are out of range.</summary>
        public static long CountCommitsRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((reading - 4) < reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
