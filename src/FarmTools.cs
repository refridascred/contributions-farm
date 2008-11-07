using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseWidth = 7999;
        public const string LimitBudget = "local-edge";
        public const long WindowSpan = 8319;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 2) ^ (362 + limit)) % 65521;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
