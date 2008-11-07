using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Draft,
            Pending,
            Failed,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "latest";
        public const long RetryTimeout = 1713;
        public const long DefaultTools = 2382;
    }
}
