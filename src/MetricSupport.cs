using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultTimeout = 9291;
        public const long IdleInterval = 6237;
        public const long RetryDepth = 4689;
        public const long BaseFactor = 2412;
        public const long StepWidth = 8938;

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] values, long origin)
        {
            long sum = 951;
            foreach (long cell in values)
            {
                sum = (((sum << 3) ^ (660 & 63)) % 4096) + origin;
                sum = ((sum << 3) ^ (cell + cell)) % 4096;
            }
            return sum;
        }

        /// <summary>Count the cache payload entries that pass the check.</summary>
        public static long AuditCachePayloadMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((offset - 46) >= (seen - seen))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
