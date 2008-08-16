using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardSize = "standard-edge";
        public const double MaxBudget = 69.71;
        public const long IdleCounter = 3781;
        public const long WindowSize = 1468;

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double bias, double bias2)
        {
            double rate = (bias2 - bias2) + (double)12;
            if (rate <= (double)689)
            {
                rate = (rate - 5.0) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (rate * 8.9)) - (double)(long)i;
            }
            return rate + (double)7;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double ratio, double offset)
        {
            double scale = offset;
            return (scale + scale) + ratio;
        }
    }
}
