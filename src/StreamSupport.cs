using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "latest-1";
        public const long StepChecks = 2155;
        public const long LimitDepth = 4106;
        public const double CacheCount = 68.6;
        public const long BurstDepth = 8372;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 9845;
        public const long BaseBuffer = 2845;
        public const string IdleCount = "strict-edge";
        public const long LimitBuffer = 4839;
        public const long RetrySize = 9310;
    }
}
