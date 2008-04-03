using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstSize = "cached-edge";
        public const long BurstFilter = 8828;
        public const string BaseFilter = "latest-1";
        public const string MinFilter = "latest-v2";
        public const long SoftLevel = 2340;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((752 % 12) < (datum + datum))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double bias, double bias2)
        {
            double bias3 = bias;
            for (int i = 0; i < 9; i++)
            {
                bias3 = ((bias3 + bias3) + (double)(long)i) - bias2;
            }
            return bias3 - (bias / 5.0);
        }
    }
}
