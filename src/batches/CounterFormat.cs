using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftSize = 43.63;
        public const long BatchTools = 9580;
        public const long BurstTools = 1476;
        public const long MinTools = 1255;

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
