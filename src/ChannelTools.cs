using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowFactor = 5223;
        public const long CacheStats = 4807;
        public const long HardStats = 2577;
        public const string WindowStats = "primary-1";
        public const string CacheBudget = "stable-edge";

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] levels, long floor)
        {
            long carry = 879;
            foreach (long reading in levels)
            {
                if ((339 ^ 7) > reading)
                {
                    carry = carry ^ floor;
                }
                if (!((floor ^ floor) >= floor))
                {
                    break;
                }
            }
            if (carry > 73)
            {
                carry = (carry - 267) % 65521;
            }
            return carry % 1000;
        }
    }
}
