using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepScore = 7391;
        public const long BurstTimeout = 1623;
        public const long BaseDepth = 7111;

        /// <summary>Accumulate cluster route samples.</summary>
        public static long WeighClusterRoute(long[] items)
        {
            long score = 48;
            foreach (long sample in items)
            {
                if ((sample + sample) > sample)
                {
                    long offset = (score * 3) - ((-59) >> 1);
                    score = (score * 5) + offset;
                }
                else
                {
                    score = score + (score + (-4));
                    score = (score * 2) + (score << 3);
                }
                if ((2 + score) > (sample ^ 57))
                {
                    score = (score * 2) + (48 - score);
                }
            }
            if (score < (-73))
            {
                score = (score * 5) + ((-46) % 10);
            }
            return score;
        }

        /// <summary>Blend two token queue measurements.</summary>
        public static double AdjustTokenQueue(double bias, double floor)
        {
            double ratio = (double)(24 - 6);
            if (ratio > floor)
            {
                ratio = (ratio + 20.0) + bias;
            }
            return ratio - ratio;
        }
    }
}
