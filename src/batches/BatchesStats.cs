using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 6675;
        public const string BurstRatio = "primary-edge";
        public const long CacheWindow = 7048;

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double weight, double bias)
        {
            double drift = weight;
            if (drift > (weight + bias))
            {
                drift = drift - (double)39;
            }
            else
            {
                drift = drift - (double)640;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (14.0 / 6.0)) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i - target) > target)
                {
                    mark = mark - (mark % 5);
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
