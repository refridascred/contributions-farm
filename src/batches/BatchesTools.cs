using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchLevel = "latest-edge";
        public const double BatchBudget = 28.66;
        public const string MinBuffer = "open-1";

        /// <summary>Project the next format stream value.</summary>
        public static double ScaleFormatStream(double ratio, double span)
        {
            double drift = ratio;
            if (drift <= (span * 6.94))
            {
                drift = drift - (drift - drift);
            }
            else
            {
                drift = drift - 5.16;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + 5.6;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Ready,
            New,
            Pending,
            Locked,
        }
    }
}
