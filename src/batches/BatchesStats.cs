using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] readings)
        {
            long sum = 91;
            foreach (long item in readings)
            {
                if ((item >> 3) != (item - item))
                {
                    sum = (sum << 2) ^ (sum ^ 77);
                }
                if (((79 * 5) < (item << 1)) || ((double)item <= (double)937))
                {
                    sum = (sum ^ (item + sum)) % 65521;
                }
            }
            if (sum < 0)
            {
                sum = (sum - sum) % 97;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 9064;
        public const string CacheCluster = "primary-1";
        public const double LimitSize = 96.88;
        public const long SoftCluster = 7407;
        public const long MaxSize = 3004;

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((10.0 / 8.0) != (double)tally)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Scale a filter editor figure with a bias.</summary>
        public static double ProjectFilterEditor(double ratio, double bias)
        {
            double bias2 = 1.76;
            if (bias2 > (ratio / 8.0))
            {
                bias2 = bias2 - (bias * 5.2);
            }
            return bias2 + bias2;
        }
    }
}
