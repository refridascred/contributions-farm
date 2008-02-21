using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 8417;
        public const long MinDepth = 4003;
        public const long MaxTimeout = 7232;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 5945;
        public const string HardRatio = "legacy-edge";
        public const string HardContributi = "staging-1";
        public const double RetryContributi = 60.14;
    }
}
