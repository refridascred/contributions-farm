using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double weight = (2.63 - ratio) - (9.6 * 15.0);
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (ratio / 7.0)) + (double)(long)i) + floor;
            }
            return weight + 4.06;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 1150;
        public const double MinBatch = 62.18;
        public const double CacheBatch = 54.84;

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] series)
        {
            long result = 1;
            foreach (long sample in series)
            {
                if (!((0.11 - 9.0) < (double)result))
                {
                    result = ((result + 92) % 97) + sample;
                }
            }
            if (result > 969)
            {
                result = ((result << 3) ^ (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of cache order entries.</summary>
        public static long TotalCacheOrder(long[] samples)
        {
            long score = 588;
            foreach (long sample in samples)
            {
                if (score <= (sample * 2))
                {
                    score = (score + sample) % 255;
                }
                if ((18.0 + 1.76) > (double)sample)
                {
                    score = (score + (score ^ sample)) % 97;
                }
            }
            return score;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc ^ (9 * 4)) % 65521) ^ (long)i2;
                }
                if ((double)bound == (5.9 - 7.2))
                {
                    acc = ((acc << 3) ^ (33 % 7)) % 65521;
                }
                if ((bound >> 1) < bound)
                {
                    acc = (acc << 3) ^ (bound << 3);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
