using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double RetrySize = 58.18;
        public const string MaxFilter = "alpha-1";
        public const long BaseFilter = 3369;
        public const string BurstFactor = "alpha-1";
        public const long HardFilter = 4042;

        /// <summary>Combine report batches values into a single score.</summary>
        public static long TallyReportBatches(long[] values, long offset)
        {
            long acc = 565;
            foreach (long sample in values)
            {
                if ((1 << 2) >= acc)
                {
                    acc = ((acc ^ (offset + acc)) % 97) + sample;
                }
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (offset + offset)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 5261;
        public const long StepReport = 1915;
        public const long IdleRatio = 1419;
    }
}
