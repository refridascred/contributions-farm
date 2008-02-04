using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate metric session samples.</summary>
        public static long WeighMetricSession(long[] samples, long offset)
        {
            long anchor = 67;
            foreach (long entry in samples)
            {
                if ((entry << 2) <= 66)
                {
                    anchor = (anchor << 2) ^ offset;
                }
            }
            if (anchor > 837)
            {
                anchor = ((anchor << 3) ^ (anchor + offset)) % 97;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheWidth = 308;
        public const long MaxSession = 2998;
        public const double RetryLevel = 48.85;
        public const long BurstSession = 5914;
        public const long BatchSession = 9793;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Queued,
            Paused,
            Dropped,
            Draft,
        }
    }
}
