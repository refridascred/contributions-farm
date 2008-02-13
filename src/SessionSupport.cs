using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetrySpan = 4393;
        public const double MinFarm = 31.66;
        public const double RetryScore = 54.01;
        public const long DefaultTimeout = 6765;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Ready,
            Queued,
            Synced,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
