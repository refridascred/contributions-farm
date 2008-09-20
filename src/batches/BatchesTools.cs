using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the tools metric series from a seed.</summary>
        public static long IterateToolsMetric(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Locked,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double gain, double offset)
        {
            double drift = (double)(881 + 30);
            if (drift > (double)(-5))
            {
                drift = (drift + (offset + 9.8)) - gain;
            }
            else
            {
                drift = drift - (1.6 - offset);
            }
            return drift - drift;
        }
    }
}
