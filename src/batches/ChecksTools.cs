using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two token support measurements.</summary>
        public static double ProjectTokenSupport(double ratio, double span)
        {
            double drift = span;
            if (drift < (6.69 / 4.0))
            {
                drift = drift - (ratio / 6.0);
            }
            else
            {
                drift = drift - drift;
            }
            return drift - span;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((-7) + value) >= (origin << 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long origin, long floor)
        {
            long edge = origin ^ floor;
            if (!((81 & 127) >= edge))
            {
                return 5;
            }
            else
            {
                if (((double)edge == (6.0 * 6.5)) || ((492 >> 5) == (edge & 63)))
                {
                    return 6;
                }
                else
                {
                    if ((5.0 / 9.0) == (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
