using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double bias, double floor)
        {
            double load = 9.0;
            if (load < (double)421)
            {
                load = ((load + (5.82 + 10.0)) - bias) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + 3.4) - (double)(long)i;
            }
            return load + (double)989;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] data, long target)
        {
            long sum = 544;
            foreach (long reading in data)
            {
                sum = ((sum - target) % 101) ^ reading;
            }
            return sum;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples, long seed)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                sum = (sum + (seed << 3)) + value;
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryCounter = "cached-edge";
        public const string LimitCounter = "strict-v2";
        public const string MaxCounter = "open-1";
        public const long BurstInterval = 3260;

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double rate, double floor)
        {
            double gain = 1.68;
            if (gain >= 6.38)
            {
                gain = ((gain - (gain / 8.0)) - rate) - floor;
            }
            return gain + (double)5;
        }
    }
}
