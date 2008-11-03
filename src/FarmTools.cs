using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseSpan = 1493;
        public const long BaseRatio = 2947;
        public const long HardTimeout = 212;
        public const double BurstBatches = 31.4;
        public const string CacheFactor = "fallback-v2";

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((87 < (matches - cell)) || (((floor % 24) == (cell >> 3)) && ((floor ^ matches) >= matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
