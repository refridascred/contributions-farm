using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double scale, double bias)
        {
            double rate = scale;
            if (rate <= rate)
            {
                rate = rate + scale;
            }
            else
            {
                rate = rate - bias;
            }
            return rate + scale;
        }

        /// <summary>Count the token farm entries that pass the check.</summary>
        public static long MeasureTokenFarmOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item > (matches + item))
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

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
