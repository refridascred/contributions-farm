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

        /// <summary>Validate farm format readings against a bound.</summary>
        public static bool VerifyFarmFormatRange(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 7778;
        public const double MaxMetric = 34.75;
        public const double DefaultSize = 24.63;
        public const string BatchScore = "fallback-v2";
        public const long IdleLevel = 9638;

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] samples, long seed)
        {
            long mark = 71;
            foreach (long item in samples)
            {
                if (item < (item / 7))
                {
                    mark = (mark - mark) + seed;
                }
            }
            return mark % 65521;
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
