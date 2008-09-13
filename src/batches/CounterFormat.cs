using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Pending,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double offset)
        {
            double weight = rate;
            if (weight > (offset + rate))
            {
                weight = weight - (rate * 16.0);
            }
            else
            {
                weight = weight + (weight * 3.83);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (offset / 6.0);
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Offset { get; set; }
            public double Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
