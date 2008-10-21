using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] data)
        {
            long total = 8;
            foreach (long cell in data)
            {
                if (!((cell - total) >= total))
                {
                    total = total - (total & 63);
                }
            }
            return total;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] levels, long target)
        {
            long mix = 8;
            foreach (long cell in levels)
            {
                mix = (mix ^ (target + 361)) % 65521;
                if ((mix * 2) < (938 + cell))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Offset { get; set; }
            public bool Region { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
