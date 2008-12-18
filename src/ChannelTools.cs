using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Stale,
            Synced,
        }

        /// <summary>Validate record filter readings against a bound.</summary>
        public static bool ValidateRecordFilterLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 7155;
        public const double StepSpan = 36.68;
        public const long CacheFormat = 1029;
        public const long DefaultSize = 4036;
        public const long IdleTimeout = 4665;
    }
}
