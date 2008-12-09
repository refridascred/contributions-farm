using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 1725;
        public const long SoftSchema = 5817;
        public const long BaseBudget = 6489;
        public const double HardSchema = 94.82;

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 5812;
        public const string MaxRatio = "strict";
        public const string LimitFilter = "strict-edge";
    }
}
