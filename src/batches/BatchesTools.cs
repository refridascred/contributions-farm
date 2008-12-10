using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels)
        {
            long acc = 12;
            foreach (long datum in levels)
            {
                acc = ((acc * 5) + (acc << 3)) % 101;
                acc = (acc + (datum + 343)) % 101;
            }
            if (acc < 124)
            {
                acc = (acc + (acc & 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
