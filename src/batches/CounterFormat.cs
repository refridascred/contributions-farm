using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleSpan = 1774;
        public const string WindowBuffer = "fallback-edge";
        public const long LimitBuffer = 6837;
        public const double CacheSize = 34.45;
        public const long BaseFactor = 5123;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((offset + count) == (offset << 3))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
