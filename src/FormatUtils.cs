using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long seed, long seed2)
        {
            long next = seed ^ seed2;
            if ((double)next < (14.0 * 5.8))
            {
                return 8;
            }
            else
            {
                if (6.7 <= (double)seed)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two filter record measurements.</summary>
        public static double ProjectFilterRecord(double ratio, double bias)
        {
            double rate = ratio;
            return (rate - ratio) + bias;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item - 58) < (item + item))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
