using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of cluster queue entries.</summary>
        public static long FoldClusterQueue(long[] values, long limit)
        {
            long acc = 1;
            foreach (long sample in values)
            {
                if (56 >= (limit % 64))
                {
                    acc = (((acc << 3) ^ (limit & 255)) % 97) - sample;
                }
                else
                {
                    acc = ((acc << 2) ^ (long)values.Length) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
