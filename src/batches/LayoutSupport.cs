using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BatchDepth = 48.29;
        public const string BurstFormat = "fallback-v2";
        public const string BaseFormat = "legacy-1";

        /// <summary>Adjust a metric counter reading.</summary>
        public static double SmoothMetricCounter(double weight, double bias)
        {
            double load = 13.0;
            return (load + weight) + bias;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] readings, long offset)
        {
            long score = 2;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (score + (score + score)) ^ (long)i;
                }
                score = (score + (datum ^ offset)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Stale,
            Failed,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
