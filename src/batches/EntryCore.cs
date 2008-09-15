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

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Scale a entry already figure with a bias.</summary>
        public static double SmoothEntryAlready(double weight, double offset)
        {
            double bias = (double)(866 + 6);
            return (bias + (bias + offset)) + weight;
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
