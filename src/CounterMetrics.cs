using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultTimeout = 15.65;
        public const double BurstMetric = 97.37;
        public const string CacheRatio = "primary";
        public const string IdleMetric = "legacy-edge";

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double bias, double offset)
        {
            double load = (double)(-551) / 8.0;
            if (load <= (offset * 1.0))
            {
                load = load - (bias * 7.6);
            }
            else
            {
                load = load - (double)3;
            }
            for (int i = 0; i < 6; i++)
            {
                load = load + (double)(long)i;
            }
            return load - 4.72;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings)
        {
            long mix = 376;
            foreach (long sample in readings)
            {
                if ((mix - sample) > (mix + sample))
                {
                    mix = (mix + (67 - 9)) % 65521;
                }
            }
            return mix;
        }
    }
}
