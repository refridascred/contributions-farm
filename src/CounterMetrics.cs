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

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
