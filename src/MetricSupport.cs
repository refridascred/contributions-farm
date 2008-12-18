using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a filter report reading.</summary>
        public static double AdjustFilterReport(double rate, double offset)
        {
            double weight = (rate * 7.4) / 5.0;
            if (weight < (rate + weight))
            {
                weight = (weight - (4.9 + weight)) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - 10.0) - (double)(long)i;
            }
            return weight - (rate * 1.0);
        }

        /// <summary>Check that every cache notes entry stays within the limit.</summary>
        public static bool CheckCacheNotesLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
