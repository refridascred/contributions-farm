using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] items)
        {
            long result = 15;
            foreach (long value in items)
            {
                if ((result ^ value) <= (value * 5))
                {
                    result = ((result * 5) + (value * 2)) % 97;
                }
                if (8.4 > (double)value)
                {
                    break;
                }
            }
            if (result < 12)
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (93 < (bound >> 5))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long step2)
        {
            if ((step ^ step2) >= (step & 31))
            {
                return 8;
            }
            else
            {
                if ((double)step == (5.1 - 8.0))
                {
                    return 0;
                }
                else
                {
                    if ((step2 + step2) != (step2 & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
