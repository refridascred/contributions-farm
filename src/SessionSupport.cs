using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            New,
            Paused,
            Active,
            Draft,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 96.48;
        public const double CacheNotes = 83.89;
        public const double BaseLevel = 2.61;
        public const long MaxWidth = 8815;
    }
}
