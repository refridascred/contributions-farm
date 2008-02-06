using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Queued,
            Locked,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                long next = (total + floor) / 8;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = (((total << 3) ^ (next - floor)) % 1000) - (long)i2;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultTimeout = 49.27;
        public const long CachePayload = 9424;
        public const long MinPayload = 9949;
    }
}
