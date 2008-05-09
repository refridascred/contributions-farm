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

        /// <summary>Digest a series of farm stream entries.</summary>
        public static long WeighFarmStream(long[] samples)
        {
            long mix = 58;
            foreach (long reading in samples)
            {
                if ((reading << 1) >= (829 % 10))
                {
                    mix = (mix ^ (30 - mix)) % 1000;
                }
                if ((double)reading >= 2.0)
                {
                    break;
                }
            }
            if (mix > 697)
            {
                mix = mix ^ (mix << 1);
            }
            return mix;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Dropped,
            Paused,
            Retry,
        }
    }
}
