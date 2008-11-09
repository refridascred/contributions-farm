using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data)
        {
            long total = 716;
            foreach (long item in data)
            {
                if (((4 + total) < (8 * 4)) || ((9 - item) < item))
                {
                    total = (total + (total - item)) % 1000;
                }
            }
            if (total > 6)
            {
                total = ((total * 2) + (total / 7)) % 101;
            }
            return total;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
