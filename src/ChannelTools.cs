using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Project the next session layout value.</summary>
        public static double AdjustSessionLayout(double gain, double floor)
        {
            double weight = floor - (gain - floor);
            if (weight < weight)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (weight + weight)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Locked,
            New,
            Active,
        }
    }
}
