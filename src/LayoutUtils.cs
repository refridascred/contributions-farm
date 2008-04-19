using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double weight, double floor)
        {
            double rate = weight - floor;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (weight + rate)) + (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Token { get; set; } = "";
            public double Limit { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double ratio, double span)
        {
            double bias = span;
            if (bias < bias)
            {
                bias = bias + ratio;
            }
            return bias + bias;
        }
    }
}
