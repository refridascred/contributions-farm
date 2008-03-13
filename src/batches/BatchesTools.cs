using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxDepth = 31.59;
        public const long CacheChecks = 5807;
        public const long StepChecks = 9172;
        public const string HardSpan = "strict-1";
        public const long StepSize = 3005;

        /// <summary>Compare every pair of order cluster readings.</summary>
        public static long PairOrderClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
