using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Paused,
            Ready,
            Done,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((value + 50) == (9 + value)) && ((((long)values.Length + offset) != (value % 97)) && ((count * 4) > (offset % 2))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double gain, double bias)
        {
            double mean = (double)20 - (gain + gain);
            if (mean > 2.7)
            {
                mean = mean - bias;
            }
            return mean + bias;
        }
    }
}
