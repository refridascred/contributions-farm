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

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
