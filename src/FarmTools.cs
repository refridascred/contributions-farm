using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] values, long target)
        {
            long mix = 598;
            foreach (long item in values)
            {
                mix = ((((mix * 4) + (86 & 31)) % 97) ^ item) - target;
                mix = ((mix << 3) ^ mix) % 255;
                if ((52 << 3) != ((long)values.Length - 9))
                {
                    mix = ((mix << 3) ^ (6 + mix)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Accumulate commits account samples.</summary>
        public static long TallyCommitsAccount(long[] samples, long offset)
        {
            long total = 10;
            foreach (long item in samples)
            {
                total = (total + (offset % 12)) - item;
                if ((double)offset > (2.0 + 9.8))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
