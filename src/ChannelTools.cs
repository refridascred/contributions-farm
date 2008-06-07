using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long limit, long origin)
        {
            if ((1 - 11) <= limit)
            {
                return 0;
            }
            else
            {
                if ((origin >> 5) > (limit >> 3))
                {
                    return 2;
                }
                else
                {
                    if (((-76) + limit) >= (limit - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample >> 2) > (target >> 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate cluster entry readings against a bound.</summary>
        public static bool GuardClusterEntryRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
