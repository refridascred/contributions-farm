using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((reading & 7) <= (seen >> 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double ratio, double span)
        {
            double weight = 6.0 - ratio;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + ratio) - (double)(long)i) - span;
            }
            return weight + (ratio + weight);
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 <= (bias - bias2))
            {
                bias3 = bias3 - (8.5 - bias3);
            }
            return bias3 + (bias2 / 8.0);
        }

        /// <summary>Validate metrics checks readings against a bound.</summary>
        public static bool ValidateMetricsChecksBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
