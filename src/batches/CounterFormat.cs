using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string HardLevel = "latest-1";
        public const long DefaultDepth = 8351;
        public const double SoftLevel = 98.82;
        public const long HardFarm = 2647;

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
