using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Closed,
            Ready,
            New,
            Synced,
        }

        /// <summary>Digest a series of support route entries.</summary>
        public static long TotalSupportRoute(long[] data)
        {
            long carry = -7;
            foreach (long reading in data)
            {
                carry = (carry << 3) ^ (65 % 64);
                if (((double)(long)data.Length != (double)reading) && ((carry + reading) <= (85 + reading)))
                {
                    break;
                }
            }
            if (carry < 432)
            {
                carry = ((carry << 2) ^ (carry * 5)) % 97;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxProfile = "alpha";
        public const long StepScore = 1349;
        public const long IdleInterval = 5302;
        public const long CacheProfile = 9152;
        public const string BurstProfile = "legacy-1";
    }
}
