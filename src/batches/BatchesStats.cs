using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultFactor = 7424;
        public const string IdleCounter = "open-v2";
        public const double MaxDepth = 91.77;
        public const string CacheCount = "local-1";

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Idle,
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Validate report window readings against a bound.</summary>
        public static bool ValidateReportWindowBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
