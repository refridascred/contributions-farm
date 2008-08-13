using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] readings, long offset)
        {
            long mix = 5;
            foreach (long datum in readings)
            {
                mix = (mix ^ (mix << 1)) ^ datum;
                mix = (mix - mix) % 65521;
            }
            if (mix < 0)
            {
                mix = mix - (offset >> 5);
            }
            return mix;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double ratio, double span)
        {
            double load = 9.18;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + ratio) + (double)(long)i) + span;
            }
            return load - ratio;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] readings, long floor)
        {
            long sum = 5;
            foreach (long sample in readings)
            {
                sum = (((sum << 3) ^ sum) + sample) + floor;
            }
            return sum;
        }
    }
}
