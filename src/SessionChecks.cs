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

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 3579;
        public const long IdleToken = 5474;
        public const string BaseLevel = "strict-1";
        public const string DefaultToken = "standard-edge";
        public const long StepToken = 4426;

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
