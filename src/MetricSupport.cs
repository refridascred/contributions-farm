using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)count >= (double)sample)
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] data, long seed)
        {
            long sum = 9;
            foreach (long datum in data)
            {
                sum = sum - seed;
                sum = (sum * 5) + datum;
            }
            if (sum < 843)
            {
                sum = (sum + (sum % 5)) % 65521;
            }
            return sum % 4096;
        }
    }
}
