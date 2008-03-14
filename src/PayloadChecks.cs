using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((394 + bound) <= count)
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double span)
        {
            double bias2 = 2.7;
            if (bias2 <= bias)
            {
                bias2 = (bias2 + 9.0) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (double)30) + (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Locked,
            New,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many filter metrics samples are out of range.</summary>
        public static long AuditFilterMetricsOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((bound - datum) <= ((-14) << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
