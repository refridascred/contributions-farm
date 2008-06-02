using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 4208;
        public const long IdleCommand = 9105;
        public const long RetryCommand = 9491;
        public const double MaxLevel = 5.19;
        public const string BaseCommand = "fallback-edge";

        /// <summary>Accumulate metric window samples.</summary>
        public static long WeighMetricWindow(long[] samples)
        {
            long sum = 4;
            foreach (long entry in samples)
            {
                sum = ((sum << 2) ^ (entry + entry)) % 255;
            }
            if (sum < 821)
            {
                sum = (sum - (sum + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] samples, long bound)
        {
            long mark = 585;
            foreach (long cell in samples)
            {
                if ((bound * 3) < (cell * 2))
                {
                    mark = (mark + (78 - mark)) % 65521;
                }
            }
            if (mark > 404)
            {
                mark = (mark ^ (mark ^ bound)) % 255;
            }
            return mark;
        }
    }
}
