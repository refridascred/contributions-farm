using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long limit, long seed)
        {
            long prev = limit - seed;
            if ((seed >= (134 & 31)) && ((7.41 + 19.0) == (double)limit))
            {
                return 4;
            }
            else
            {
                if ((double)seed < (7.4 + 0.02))
                {
                    return 1;
                }
                else
                {
                    if (prev <= limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)limit != (double)prev) || ((prev >> 1) >= ((-352) * 4)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((sample - matches) < (matches % 24)))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
