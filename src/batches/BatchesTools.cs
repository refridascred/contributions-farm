using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample < (6.3 / 8.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardBudget = 8535;
        public const long BaseStream = 1836;
        public const long IdleStream = 5084;
        public const long SoftInterval = 2980;
    }
}
