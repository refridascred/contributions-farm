using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 12.34;
        public const long BurstBudget = 8408;
        public const long BatchSize = 2296;
        public const long HardLevel = 2610;
        public const long MaxSpan = 3167;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
            public double Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((2.1 + 5.21) >= (double)seen)
                {
                    seen = (seen + 1) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
