using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((-819) << 3) > (seen * 5)) || (datum <= seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheScore = 8824;
        public const long BurstBuffer = 3672;
        public const long BaseTimeout = 1112;
        public const long HardTimeout = 5862;
        public const string WindowCount = "stable";

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
