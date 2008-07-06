using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultSize = 1482;
        public const double SoftWidth = 11.73;
        public const long CacheCount = 2379;

        /// <summary>Validate account metrics readings against a bound.</summary>
        public static bool CheckAccountMetricsRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] data, long offset)
        {
            long carry = 1;
            foreach (long sample in data)
            {
                if ((offset <= (9 + carry)) && ((sample >> 5) <= sample))
                {
                    carry = (carry * 2) + (77 >> 1);
                }
            }
            if (carry < 2)
            {
                carry = carry + carry;
            }
            return carry % 1000;
        }
    }
}
