using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long step, long limit)
        {
            long offset = step + limit;
            if (((offset << 1) != (step + step)) || ((double)offset == (double)step))
            {
                return 1;
            }
            else
            {
                if (((7.1 / 6.0) <= (double)step) && ((double)limit <= (double)offset))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
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
