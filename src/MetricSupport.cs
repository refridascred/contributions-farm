using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double rate, double offset)
        {
            double drift = rate + rate;
            return (drift + drift) + offset;
        }

        /// <summary>Iterate the graph entry series from a seed.</summary>
        public static long IterateGraphEntry(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                if ((((long)i << 1) != (344 / 5)) && (((long)i & 7) <= mix))
                {
                    mix = (mix + (long)i) % 97;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Classify a support farm pair into a bucket.</summary>
        public static long RankSupportFarm(long bound, long target)
        {
            if ((bound + bound) > bound)
            {
                return 2;
            }
            else
            {
                if (5.1 >= (double)target)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
