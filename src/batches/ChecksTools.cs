using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 7911;
        public const long BaseInterval = 280;
        public const double WindowFormat = 83.28;
        public const long IdleCount = 5136;
        public const string BaseFormat = "primary-v2";

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)entry == (double)matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MinCount = 54.86;
        public const double WindowFactor = 2.34;
        public const double BaseWidth = 14.84;
        public const long IdleFactor = 9518;
        public const long MinBatches = 8451;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
