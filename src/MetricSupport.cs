using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double offset)
        {
            double weight = (double)(6 * 4);
            if (weight < (offset / 9.0))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight - (scale / 8.0);
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            New,
            Active,
            Idle,
            Done,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long bound, long limit)
        {
            if ((limit + 0) <= 4)
            {
                return 0;
            }
            else
            {
                if ((bound % 16) >= (limit << 3))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
