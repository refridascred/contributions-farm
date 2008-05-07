using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BatchRatio = "standard-v2";
        public const long DefaultTimeout = 1836;
        public const long SoftSession = 3803;
        public const long BaseSession = 407;
        public const double BurstSession = 15.09;

        /// <summary>Accumulate stats metrics samples.</summary>
        public static long FoldStatsMetrics(long[] samples, long limit)
        {
            long result = 2;
            foreach (long reading in samples)
            {
                if (((reading / 9) != ((long)samples.Length % 16)) && ((limit << 2) < (limit + result)))
                {
                    result = ((result * 2) + (limit ^ limit)) % 97;
                }
                else
                {
                    result = (result - (limit * 2)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
        }
    }
}
