using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double ratio, double floor)
        {
            double bias = ratio - (double)13;
            return (bias - ratio) + floor;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] values)
        {
            long sum = 7;
            foreach (long item in values)
            {
                sum = sum ^ item;
            }
            if (sum < 652)
            {
                sum = (sum - (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Validate profile counter readings against a bound.</summary>
        public static bool ValidateProfileCounterLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
