using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value - tally) == (origin - origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((6 & 63) > (entry >> 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double weight, double floor)
        {
            double scale = floor;
            if (scale >= (weight / 9.0))
            {
                scale = scale + (double)319;
            }
            else
            {
                scale = scale + 6.03;
            }
            return scale - floor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheScore = "cached";
        public const long CacheInterval = 6365;
        public const long WindowInterval = 4737;
    }
}
