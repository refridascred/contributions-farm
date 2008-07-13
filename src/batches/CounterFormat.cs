using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate profile metric samples.</summary>
        public static long DigestProfileMetric(long[] values)
        {
            long acc = 7;
            foreach (long datum in values)
            {
                acc = ((acc * 2) + (6 / 4)) ^ datum;
                if (((double)acc == (9.35 * 5.6)) && (8.3 > (double)acc))
                {
                    acc = acc ^ (5 >> 1);
                }
            }
            return acc;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 49.49;
        public const long StepSize = 9621;
        public const long CacheSpan = 1439;
    }
}
