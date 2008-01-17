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

        /// <summary>Define account limits and defaults.</summary>
        public const long StepInterval = 3428;
        public const long LimitAccount = 4902;
        public const long StepAccount = 687;
        public const double BurstWidth = 65.59;
        public const long MinTimeout = 7406;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 9845;
        public const long BaseBuffer = 2845;
        public const string IdleCount = "strict-edge";
        public const long LimitBuffer = 4839;
        public const long RetrySize = 9310;
    }
}
