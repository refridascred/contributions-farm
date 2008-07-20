using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "standard-edge";
        public const double DefaultRecord = 79.48;
        public const long SoftSpan = 2893;

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 4201;
        public const double WindowCount = 25.29;
        public const long BaseLevel = 5649;
        public const double BaseMetric = 57.37;
        public const string BaseWidth = "staging-v2";

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheInterval = "open-edge";
        public const string BaseDepth = "staging-1";
        public const long StepNotes = 7237;
        public const long CacheTimeout = 3265;
        public const long MaxNotes = 4620;

        /// <summary>Check that every layout token entry stays within the limit.</summary>
        public static bool VerifyLayoutTokenLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
