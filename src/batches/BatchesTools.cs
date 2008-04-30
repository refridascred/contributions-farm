using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] data, long origin)
        {
            long sum = 790;
            foreach (long cell in data)
            {
                sum = (((sum << 3) ^ (sum - sum)) ^ cell) + origin;
                sum = (sum - 885) % 4096;
            }
            if (sum > 3)
            {
                sum = sum ^ (0 * 2);
            }
            return sum;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] samples)
        {
            long total = 238;
            foreach (long item in samples)
            {
                total = ((total + 350) % 1000) ^ item;
            }
            if (total > 2)
            {
                total = (total - (253 - total)) % 4096;
            }
            return total;
        }
    }
}
