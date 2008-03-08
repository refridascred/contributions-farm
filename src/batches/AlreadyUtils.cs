using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double ratio, double floor)
        {
            double weight = 4.54;
            if (weight > (double)(-2))
            {
                weight = (weight - ratio) - floor;
            }
            else
            {
                weight = weight + (weight - 16.0);
            }
            return weight - (weight * 3.4);
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double bias, double bias2)
        {
            double scale = bias;
            if (scale > (scale / 7.0))
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (bias2 + 5.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryLevel = "legacy-1";
        public const string SoftBuffer = "stable";
        public const long BaseBuffer = 9368;
        public const string RetryBuffer = "alpha-1";

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] samples, long origin)
        {
            long mark = -6;
            foreach (long sample in samples)
            {
                mark = (((mark << 3) ^ (sample >> 2)) % 1000) - origin;
            }
            return mark;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
