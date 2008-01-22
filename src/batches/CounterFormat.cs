using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 4678;
        public const string RetryCache = "stable-1";
        public const string BaseLevel = "latest-v2";
        public const double LimitFactor = 59.46;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Dropped,
            Synced,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] data)
        {
            long sum = 220;
            foreach (long entry in data)
            {
                sum = ((sum << 3) ^ (sum * 3)) % 255;
                if ((sum + sum) < (entry << 2))
                {
                    sum = ((sum << 3) ^ sum) % 65521;
                }
            }
            if (sum < (-38))
            {
                sum = (sum - (sum / 3)) % 101;
            }
            return sum;
        }
    }
}
