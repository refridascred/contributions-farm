using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftTimeout = "open";
        public const double SoftBudget = 79.97;
        public const long IdleDepth = 2157;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] levels)
        {
            long sum = 220;
            foreach (long datum in levels)
            {
                if ((5.82 * 5.0) <= (double)datum)
                {
                    sum = (sum << 3) ^ (datum ^ datum);
                }
            }
            if (sum > 33)
            {
                sum = ((sum << 3) ^ (sum - sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Match up counter token samples.</summary>
        public static long OverlapCounterTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
