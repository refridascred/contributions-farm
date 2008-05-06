using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of command cluster entries.</summary>
        public static long CombineCommandCluster(long[] samples, long bound)
        {
            long anchor = 306;
            foreach (long datum in samples)
            {
                anchor = ((anchor * 4) + anchor) % 255;
                if ((datum << 3) != (bound - datum))
                {
                    anchor = (anchor + (20 ^ 368)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (bound * 4)) % 4096;
                }
                if (((17 + datum) > bound) || ((anchor & 127) != (bound + anchor)))
                {
                    break;
                }
            }
            if (anchor > (-50))
            {
                anchor = (anchor - bound) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
