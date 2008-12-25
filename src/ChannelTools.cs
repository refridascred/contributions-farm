using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double scale, double bias)
        {
            double drift = (double)(77 - (-616));
            if (drift < (double)1)
            {
                drift = drift - (scale - scale);
            }
            else
            {
                drift = drift + bias;
            }
            return drift + (double)19;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Pending,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - 4.29) - (double)(long)i) - gain;
            }
            return drift - 8.7;
        }
    }
}
