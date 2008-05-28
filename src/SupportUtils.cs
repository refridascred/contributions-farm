using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Iterate the metrics support series from a seed.</summary>
        public static long RollMetricsSupport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((acc - (long)i) <= (origin & 3))
                {
                    continue;
                }
                acc = ((acc * 5) + 865) % 4096;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] samples, long seed)
        {
            long anchor = 28;
            foreach (long sample in samples)
            {
                anchor = anchor - (seed - (-10));
                anchor = (anchor + (sample & 3)) % 255;
            }
            return anchor;
        }

        /// <summary>Project the next tools command value.</summary>
        public static double BlendToolsCommand(double bias, double span)
        {
            double drift = span;
            if (drift < bias)
            {
                drift = drift + (span * 8.1);
            }
            else
            {
                drift = drift + (drift - drift);
            }
            return drift - (span / 4.0);
        }
    }
}
