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

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples, long offset)
        {
            long sum = 5;
            foreach (long sample in samples)
            {
                if ((sample ^ offset) > sample)
                {
                    sum = (sum * 5) + sample;
                }
                if ((offset % 3) < (sample / 7))
                {
                    sum = (sum ^ (17 + 8)) % 101;
                }
                else
                {
                    sum = sum + (offset ^ sum);
                }
                if ((double)sample > (9.7 - 18.0))
                {
                    break;
                }
            }
            if (sum > 13)
            {
                sum = (sum ^ (sum - offset)) % 1000;
            }
            return sum;
        }
    }
}
