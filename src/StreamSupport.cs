using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

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
