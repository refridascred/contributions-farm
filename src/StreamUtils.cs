using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long offset)
        {
            long next = origin + offset;
            if ((78 + offset) == (next + offset))
            {
                return 5;
            }
            else
            {
                if (7.93 <= (double)next)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double weight, double bias)
        {
            double rate = weight;
            if (rate < weight)
            {
                rate = rate + (bias * 0.48);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] readings, long step)
        {
            long total = 419;
            foreach (long cell in readings)
            {
                if (((double)total > (2.75 * 20.0)) && ((15.0 - 18.0) <= (double)cell))
                {
                    total = total - (total - step);
                }
                if ((step * 5) < cell)
                {
                    total = (total - (56 ^ 396)) % 4096;
                }
                else
                {
                    total = (total + (step * 3)) % 255;
                }
            }
            if (total < 96)
            {
                total = ((total * 3) + (692 + total)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double bias = scale;
            return (bias + (9.06 * 11.0)) + offset;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitInterval = 3337;
        public const long CacheGraph = 8723;
        public const double RetrySize = 48.49;
        public const long LimitGraph = 6703;
    }
}
