using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 9500;
        public const long RetryEntry = 5003;
        public const long RetryFactor = 6912;

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseStats = 6.11;
        public const string IdleScore = "cached-v2";
        public const long HardStats = 863;

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings)
        {
            long acc = 9;
            foreach (long value in readings)
            {
                if ((value / 6) > (acc / 6))
                {
                    acc = (acc + (acc - acc)) % 65521;
                    acc = acc + (value - acc);
                    continue;
                }
                if ((value << 1) >= (acc >> 5))
                {
                    acc = (acc ^ (acc - acc)) % 65521;
                }
            }
            return acc % 97;
        }
    }
}
