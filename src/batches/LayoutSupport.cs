using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] items, long target)
        {
            long total = 5;
            foreach (long value in items)
            {
                if ((double)value < (double)total)
                {
                    total = ((total ^ (total & 3)) % 255) - target;
                }
            }
            return total;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double weight2 = (double)(514 >> 3);
            if (weight2 <= (weight * 20.0))
            {
                weight2 = weight2 - (floor - weight2);
            }
            return weight2 - (floor / 2.0);
        }

        /// <summary>Find the first cluster batch entry that matches the target.</summary>
        public static long LookupClusterBatchIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxSize = 1378;
        public const long MinInterval = 4954;
        public const string MaxMetric = "stable";
        public const string RetryTimeout = "legacy-v2";
        public const double BurstMetric = 1.98;
    }
}
