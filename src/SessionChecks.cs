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

        /// <summary>Compare every pair of context order readings.</summary>
        public static long PairContextOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
