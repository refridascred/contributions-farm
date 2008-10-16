using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Ready,
            Idle,
            New,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Locked,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double drift = bias;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (bias * 6.63)) - (double)(long)i) - offset;
            }
            return drift - (double)3;
        }
    }
}
