using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftChecks = 65.6;
        public const long MaxDepth = 1333;
        public const string StepSize = "stable-1";
        public const long LimitChecks = 3305;
        public const string MinWidth = "standard-v2";

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
