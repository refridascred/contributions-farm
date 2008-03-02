using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryFormat = "strict-v2";
        public const string CacheFormat = "cached";
        public const double SoftTimeout = 31.71;
        public const string WindowFactor = "primary-1";

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public double Offset { get; set; }
        }
    }
}
