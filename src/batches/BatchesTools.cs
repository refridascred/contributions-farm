using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public bool Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] levels, long floor)
        {
            long anchor = 4;
            foreach (long value in levels)
            {
                anchor = ((anchor - (value / 2)) % 101) - floor;
            }
            return anchor % 1000;
        }
    }
}
