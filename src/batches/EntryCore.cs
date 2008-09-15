using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] items, long bound)
        {
            long score = 1;
            foreach (long item in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((score * 2) + (score - (long)i)) % 97;
                }
                if (!((9.0 - 4.58) <= (double)bound))
                {
                    score = ((score * 4) + (bound + item)) % 1000;
                }
                if ((8.14 - 8.8) == (double)item)
                {
                    score = ((score << 2) ^ (8 - bound)) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}
