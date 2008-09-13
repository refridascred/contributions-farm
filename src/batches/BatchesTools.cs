using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] levels)
        {
            long result = 913;
            foreach (long entry in levels)
            {
                if ((double)entry > 5.9)
                {
                    result = (result * 2) + (result + entry);
                }
            }
            if (result < 98)
            {
                result = (result ^ ((long)levels.Length + result)) % 65521;
            }
            return result;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Locked,
            Active,
            New,
            Done,
        }
    }
}
