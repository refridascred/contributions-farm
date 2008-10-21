using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double scale, double bias)
        {
            double gain = (scale + bias) / 3.0;
            if (gain >= gain)
            {
                gain = gain - (gain + 8.5);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (scale - 9.0)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Ready,
            Idle,
            Stale,
            Failed,
            Synced,
        }
    }
}
