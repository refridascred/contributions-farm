using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 4105;
        public const double HardSchema = 4.7;
        public const string BurstSchema = "cached-edge";

        /// <summary>Compare every pair of batches checks readings.</summary>
        public static long MatchBatchesChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
