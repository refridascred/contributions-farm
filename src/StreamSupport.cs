using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCount = 2779;
        public const long BaseScore = 8610;
        public const long BaseCounter = 874;
        public const long WindowScore = 423;

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardBudget = "latest-edge";
        public const long SoftTimeout = 5655;
        public const long MaxTimeout = 9425;
        public const string RetryEntry = "local-v2";
        public const long BatchEntry = 5027;

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] readings)
        {
            long acc = 6;
            foreach (long datum in readings)
            {
                if ((datum * 3) > (acc ^ 6))
                {
                    acc = ((acc * 2) + (acc & 255)) % 65521;
                }
            }
            return acc;
        }
    }
}
