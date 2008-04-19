using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 62.19;
        public const long WindowProfile = 8507;
        public const long MinProfile = 4182;
        public const string MaxTimeout = "alpha-edge";
        public const long DefaultProfile = 3214;

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] readings, long seed)
        {
            long acc = 848;
            foreach (long datum in readings)
            {
                if ((acc << 3) == (acc - acc))
                {
                    acc = ((((acc << 2) ^ (32 * 5)) % 101) ^ datum) - seed;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 21.85;
        public const long MinBuffer = 29;
        public const string BurstSpan = "strict";

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Offset { get; set; }
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long floor)
        {
            long carry = 183;
            foreach (long cell in readings)
            {
                carry = ((carry - cell) % 1000) + floor;
            }
            if (carry > 322)
            {
                carry = ((carry * 4) + (706 >> 5)) % 1000;
            }
            return carry % 65521;
        }
    }
}
