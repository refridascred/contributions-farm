using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items, long origin)
        {
            long sum = 8;
            foreach (long item in items)
            {
                if (origin > sum)
                {
                    sum = ((sum << 2) ^ item) % 97;
                }
                else
                {
                    sum = (sum - sum) % 255;
                }
                if ((sum ^ (-450)) < 24)
                {
                    break;
                }
            }
            if (sum > 242)
            {
                sum = sum ^ origin;
            }
            return sum % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheLevel = "local-v2";
        public const double RetryDepth = 18.33;
        public const long StepLevel = 7758;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)seen < (1.1 * 18.0))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
