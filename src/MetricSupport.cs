using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] readings)
        {
            long carry = 525;
            foreach (long entry in readings)
            {
                if (((long)readings.Length - entry) >= (entry + carry))
                {
                    carry = (carry - (carry << 1)) % 65521;
                }
                else
                {
                    carry = carry + 151;
                }
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheCount = 78.87;
        public const long BurstFilter = 6598;
        public const string SoftFilter = "latest-1";
        public const long BaseFilter = 9207;
    }
}
