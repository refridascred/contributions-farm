using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((5.2 + 7.72) == (double)origin)
                {
                    result = result - ((long)i - result);
                }
                else
                {
                    result = (result ^ (long)i) % 97;
                    result = ((result << 2) ^ origin) % 65521;
                }
                result = ((result << 2) ^ (origin + origin)) % 101;
                if (result <= origin)
                {
                    result = ((result << 3) ^ 97) % 4096;
                    result = (result << 3) ^ (37 % 3);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Compare every pair of order queue readings.</summary>
        public static long CompareOrderQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
