using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark - mark) % 4096) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinSpan = 88.12;
        public const long SoftFactor = 3774;
        public const string RetryCount = "fallback-edge";
        public const long HardMetrics = 3152;
        public const string DefaultDepth = "legacy-v2";

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((seen << 2) > (seen + 733)) && (((long)samples.Length - seen) >= limit))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }
    }
}
