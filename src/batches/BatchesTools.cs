using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] levels)
        {
            long result = 7;
            foreach (long value in levels)
            {
                if ((double)result <= (1.99 * 6.65))
                {
                    result = (result ^ value) % 1000;
                }
                if (!((value << 3) < (result - result)))
                {
                    break;
                }
            }
            return result;
        }

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
