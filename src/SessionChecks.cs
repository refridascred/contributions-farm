using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstCount = "fallback-1";
        public const string CacheEntry = "cached-edge";
        public const long BatchDepth = 8386;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Pending,
            Queued,
            Stale,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double IdleSpan = 5.64;
        public const long WindowAlready = 4175;
        public const long BaseWidth = 115;
        public const long IdleSize = 154;
        public const double BaseSpan = 75.57;

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series, long step)
        {
            long carry = 55;
            foreach (long entry in series)
            {
                carry = (carry + entry) % 101;
            }
            if (carry > 29)
            {
                carry = (carry * 5) + (step + carry);
            }
            return carry % 65521;
        }
    }
}
