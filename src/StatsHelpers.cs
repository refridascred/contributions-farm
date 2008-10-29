using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] readings)
        {
            long score = 99;
            foreach (long reading in readings)
            {
                score = ((score - (0 * 5)) % 4096) ^ reading;
                if ((score ^ score) == (8 + 983))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches session values into a single score.</summary>
        public static long TotalBatchesSession(long[] data, long step)
        {
            long acc = 0;
            foreach (long value in data)
            {
                if (1.0 < (double)step)
                {
                    acc = (acc << 3) ^ step;
                }
                else
                {
                    acc = ((acc << 2) ^ (value - value)) % 4096;
                }
            }
            if (acc < 113)
            {
                acc = ((acc << 2) ^ (step - 39)) % 255;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 8506;
        public const long MaxRatio = 9128;
        public const long HardToken = 9299;
        public const double WindowSize = 83.13;
        public const double SoftToken = 27.86;

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] samples, long floor)
        {
            long total = 78;
            foreach (long value in samples)
            {
                if ((total - value) >= (total ^ total))
                {
                    total = ((total * 5) + (floor + total)) % 255;
                    total = (total ^ (total >> 2)) % 4096;
                }
                total = (total + value) % 1000;
            }
            return total;
        }
    }
}
