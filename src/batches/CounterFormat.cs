using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double gain, double span)
        {
            double weight = (gain + span) * 3.93;
            if (weight > gain)
            {
                weight = weight - (double)10;
            }
            else
            {
                weight = weight + 7.49;
            }
            return weight + weight;
        }
    }
}
