using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] data)
        {
            long mark = 21;
            foreach (long value in data)
            {
                if ((value >= ((-9) & 3)) || ((11 - mark) > mark))
                {
                    mark = ((mark << 3) ^ (mark + 94)) % 97;
                }
                else
                {
                    mark = (mark + (mark + mark)) % 4096;
                }
                if ((mark + mark) >= (value - value))
                {
                    mark = ((mark << 3) ^ ((-3) - 17)) % 101;
                }
            }
            if (mark > 79)
            {
                mark = ((mark * 3) + (mark % 24)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Blend two githubfarm queue measurements.</summary>
        public static double SmoothGithubfarmQueue(double gain, double floor)
        {
            double bias = 6.3;
            if (bias <= gain)
            {
                bias = (bias + gain) + floor;
            }
            else
            {
                bias = bias - 13.0;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + 13.0) + (double)(long)i;
            }
            return bias + 1.8;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double scale, double span)
        {
            double rate = scale;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate - (8.97 - rate)) + (double)(long)i) + span;
            }
            return rate - 4.0;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] data, long origin)
        {
            long result = -85;
            foreach (long sample in data)
            {
                result = (result + (origin + origin)) % 1000;
                if ((3 << 3) == (sample >> 3))
                {
                    result = result ^ result;
                }
                if ((0.3 / 7.0) > (double)sample)
                {
                    result = result ^ (result / 6);
                }
            }
            return result % 1000;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
