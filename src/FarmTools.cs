using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings, long seed)
        {
            long carry = 625;
            foreach (long cell in readings)
            {
                if ((509 <= (cell - cell)) || ((14.0 + 5.29) < (double)carry))
                {
                    carry = ((carry ^ (548 - cell)) % 1000) + seed;
                }
            }
            return carry;
        }

        /// <summary>Count record batch pairs that satisfy a relation.</summary>
        public static long PairRecordBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
