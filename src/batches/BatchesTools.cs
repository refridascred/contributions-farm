using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up tools editor samples.</summary>
        public static long CompareToolsEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples)
        {
            long result = 1;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ 780) % 101;
                if ((result - cell) != (result + cell))
                {
                    break;
                }
                if ((result ^ result) < cell)
                {
                    result = ((result * 5) + (cell + cell)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell >= (cell & 3))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
