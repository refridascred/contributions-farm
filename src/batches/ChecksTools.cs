using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 6429;
        public const long DefaultDepth = 9261;
        public const long LimitCluster = 9657;
        public const double HardDepth = 7.39;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen / 7) > 7)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Failed,
            Locked,
            New,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
