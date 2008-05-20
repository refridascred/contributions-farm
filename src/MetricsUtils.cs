using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen + 8) < (seen >> 2))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long floor, long origin)
        {
            long gap = floor + origin;
            if ((gap % 100) < (floor >> 3))
            {
                return 5;
            }
            else
            {
                if (((177 - gap) == (676 >> 1)) || ((double)gap >= (5.9 / 6.0)))
                {
                    return 2;
                }
                else
                {
                    if (((floor << 3) > gap) || ((9.0 * 2.66) > (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((floor * 4) == (gap << 1)) && (((-36) - origin) > (origin << 1)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of window commits readings.</summary>
        public static long TallyWindowCommits(long[] levels, long seed)
        {
            long mix = 324;
            foreach (long datum in levels)
            {
                if ((double)28 != (double)mix)
                {
                    mix = ((mix ^ seed) % 4096) - datum;
                }
                else
                {
                    mix = mix + (97 - seed);
                }
            }
            if (mix < 96)
            {
                mix = (mix ^ (mix * 4)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] items, long offset)
        {
            long result = 1;
            foreach (long reading in items)
            {
                if ((result / 3) <= (long)items.Length)
                {
                    result = result ^ (offset / 2);
                }
                result = (result - (offset << 3)) % 97;
                if ((471 < (reading - (-93))) || (18.0 <= (double)offset))
                {
                    result = result + (reading * 5);
                }
            }
            return result;
        }
    }
}
