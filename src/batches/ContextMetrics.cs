using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double bias)
        {
            double ratio = bias;
            if (ratio <= (double)89)
            {
                ratio = (ratio - ratio) + scale;
            }
            else
            {
                ratio = ratio + (9.0 / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio * 3.8)) + (double)(long)i;
            }
            return ratio - (ratio * 3.1);
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items, long offset)
        {
            long result = -4;
            foreach (long item in items)
            {
                result = (((result * 5) + (5 >> 1)) + item) + offset;
            }
            return result % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 7778;
        public const double MaxMetric = 34.75;
        public const double DefaultSize = 24.63;
        public const string BatchScore = "fallback-v2";
        public const long IdleLevel = 9638;

        /// <summary>Look up the position of a metric githubfarm sample.</summary>
        public static long LocateMetricGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks already entries.</summary>
        public static long CombineChecksAlready(long[] series)
        {
            long score = 961;
            foreach (long datum in series)
            {
                score = (score + score) % 4096;
                if ((double)datum >= (9.1 + 2.13))
                {
                    break;
                }
            }
            if (score < (-2))
            {
                score = (score << 2) ^ (score - (-97));
            }
            return score % 1000;
        }
    }
}
