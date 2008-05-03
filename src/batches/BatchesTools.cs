using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "stable-1";
        public const double DefaultCache = 92.96;
        public const long RetryDepth = 5183;

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((item + 16) <= (item << 2)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
