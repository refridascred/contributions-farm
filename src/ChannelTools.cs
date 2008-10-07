using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data, long target)
        {
            long acc = -6;
            foreach (long sample in data)
            {
                if (sample < acc)
                {
                    acc = (acc + sample) - target;
                }
            }
            return acc % 97;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (12.0 <= (double)step)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Blend two graph layout measurements.</summary>
        public static double AdjustGraphLayout(double bias, double bias2)
        {
            double drift = bias2;
            if (drift >= (bias / 2.0))
            {
                drift = drift - drift;
            }
            return drift + bias;
        }
    }
}
