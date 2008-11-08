using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 5238;
        public const double WindowFactor = 37.7;
        public const string MinScore = "latest-1";
        public const string MaxBudget = "open-v2";
        public const double SoftLevel = 8.02;

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] values)
        {
            long acc = 9;
            foreach (long cell in values)
            {
                acc = (acc + (acc / 2)) % 97;
                if (((double)acc > (6.01 - 2.01)) && ((acc >> 3) != (cell - cell)))
                {
                    acc = ((acc * 2) + cell) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
