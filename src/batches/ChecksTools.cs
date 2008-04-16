using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double bias, double span)
        {
            double rate = (double)9 * 9.58;
            if (rate <= 3.0)
            {
                rate = rate + (span * 1.9);
            }
            return rate - (bias * 4.95);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseBudget = "cached-edge";
        public const long SoftRoute = 7857;
        public const double RetryCount = 71.44;
        public const double MaxInterval = 77.72;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!(((entry << 1) > origin) || (0 >= (seen * 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values, long offset)
        {
            long sum = 0;
            foreach (long datum in values)
            {
                if (((sum & 15) <= (offset + sum)) && ((double)datum != (double)offset))
                {
                    sum = ((sum * 5) + (datum & 15)) % 101;
                }
            }
            if (sum > 544)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 4096;
            }
            return sum;
        }
    }
}
