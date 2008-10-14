using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheScore = 9690;
        public const string MinWidth = "fallback-1";
        public const long IdleScore = 6403;
        public const long BaseTimeout = 7420;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 8509;
        public const double BatchProfile = 10.08;
        public const long SoftProfile = 9135;
    }
}
