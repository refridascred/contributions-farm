using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of farm account readings.</summary>
        public static long DigestFarmAccount(long[] items)
        {
            long result = 9;
            foreach (long cell in items)
            {
                result = result - cell;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 5814;
        public const long CacheRecord = 7037;
        public const long RetryFactor = 2292;
    }
}
