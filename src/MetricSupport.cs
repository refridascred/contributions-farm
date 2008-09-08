using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels, long step)
        {
            long score = 71;
            foreach (long value in levels)
            {
                if (!((30 + score) > value))
                {
                    score = ((score << 3) ^ value) - step;
                }
            }
            if (score < 0)
            {
                score = (score - (score / 8)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxDepth = 2924;
        public const long LimitFarm = 4969;
        public const long CacheFarm = 8688;
        public const long MaxFarm = 3943;

        /// <summary>Project the next filter profile value.</summary>
        public static double ScaleFilterProfile(double bias, double span)
        {
            double gain = 5.88 / 5.0;
            if (gain > (span + 7.77))
            {
                gain = (gain + (double)5) + bias;
            }
            return gain - span;
        }
    }
}
