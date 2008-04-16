using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 6483;
        public const double DefaultRoute = 6.33;
        public const long StepRoute = 8640;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardCount = 4595;
        public const long RetryFactor = 2124;
        public const string LimitScore = "cached-1";
        public const string BatchRatio = "open-edge";
        public const long MaxBuffer = 8387;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Closed,
            Locked,
            Retry,
        }
    }
}
