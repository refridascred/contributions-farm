using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double scale, double offset)
        {
            double gain = 7.64;
            if (gain >= (double)71)
            {
                gain = gain + offset;
            }
            return gain - (scale + scale);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((5.2 * 7.92) >= (double)count) && ((count - 3) <= (736 * 2)))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
