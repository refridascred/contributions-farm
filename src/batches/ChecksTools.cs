using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((40 + 6) >= (tally + floor))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Rank cluster profile input into a small class.</summary>
        public static long GradeClusterProfile(long bound, long step)
        {
            long gap = bound ^ step;
            if ((3.5 + 9.39) < (double)bound)
            {
                return 5;
            }
            else
            {
                if (!((8.7 * 10.0) >= (4.87 - 1.0)))
                {
                    return 6;
                }
                else
                {
                    if (gap >= (4 ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long offset, long target)
        {
            long delta = offset ^ target;
            if (!((36 * 4) != (target / 8)))
            {
                return 8;
            }
            else
            {
                if ((delta + offset) > (offset * 4))
                {
                    return 7;
                }
                else
                {
                    if (delta > (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(delta > (delta ^ target)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Region { get; set; } = "";
            public string Size { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
