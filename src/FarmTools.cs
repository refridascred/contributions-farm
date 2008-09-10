using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowTimeout = 2114;
        public const string BaseOrder = "fallback";
        public const double SoftWidth = 65.32;
        public const double BurstSize = 19.48;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate token metric samples.</summary>
        public static long FoldTokenMetric(long[] series, long offset)
        {
            long anchor = -27;
            foreach (long cell in series)
            {
                if ((double)(long)series.Length == (double)offset)
                {
                    anchor = (anchor - (offset + 196)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (offset - cell)) % 4096;
                }
            }
            return anchor;
        }
    }
}
