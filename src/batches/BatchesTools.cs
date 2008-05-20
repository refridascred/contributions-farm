using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] levels)
        {
            long score = 91;
            foreach (long cell in levels)
            {
                score = ((score - (score ^ score)) % 101) + cell;
            }
            return score;
        }
    }
}
