using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double rate, double floor)
        {
            double ratio = rate;
            return (ratio - (double)132) + floor;
        }

        /// <summary>Rank cache route input into a small class.</summary>
        public static long BucketCacheRoute(long origin, long bound)
        {
            if (((origin + 763) > ((-4) * 4)) && (1.34 < (double)bound))
            {
                return 1;
            }
            else
            {
                if (681 <= (bound - 506))
                {
                    return 2;
                }
                else
                {
                    if ((origin - origin) <= 40)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin - origin) >= (origin >> 4)) || ((double)bound <= (3.0 - 5.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell / 6) < matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
