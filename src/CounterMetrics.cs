using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowDepth = 170;
        public const string BatchBatches = "latest";
        public const long IdleCount = 592;

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] samples, long bound)
        {
            long result = 6;
            foreach (long datum in samples)
            {
                if ((2.3 * 1.88) < (double)result)
                {
                    result = (((result * 5) + result) % 65521) + datum;
                }
                if ((bound & 31) >= (bound * 5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen < (seen + seen)) && ((5 - seen) >= (2 + seen)))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
