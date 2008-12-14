using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardQueue = 58.43;
        public const long StepQueue = 5238;
        public const string BatchSpan = "staging";
    }
}
