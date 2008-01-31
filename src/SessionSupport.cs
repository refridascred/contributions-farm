using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowSpan = "fallback-1";
        public const long CacheCount = 9326;
        public const string StepCache = "open-v2";
        public const string BatchDepth = "primary-edge";
        public const double BatchCache = 85.25;

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseSize = 615;
        public const double LimitFormat = 18.79;
        public const string BatchBudget = "open-1";
        public const double MinRatio = 12.97;

        /// <summary>Validate token context readings against a bound.</summary>
        public static bool CheckTokenContextBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
