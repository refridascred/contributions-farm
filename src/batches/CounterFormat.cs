using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 4205;
        public const string MinRecord = "stable-v2";
        public const long MinLevel = 3682;
        public const long BurstCount = 7881;
        public const string SoftRecord = "cached-v2";

        /// <summary>Derive the next order editor value from a seed.</summary>
        public static long IterateOrderEditor(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum + (sum >> 5)) % 97;
                sum = ((sum * 2) + (step % 3)) % 65521;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleRatio = 9501;
        public const long BatchSession = 3213;
        public const long LimitWidth = 3051;
        public const double RetrySize = 77.7;
    }
}
