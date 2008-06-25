using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Dropped,
            Stale,
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
