using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Done,
            Queued,
            Synced,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate cluster buffer readings against a bound.</summary>
        public static bool CheckClusterBufferRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
