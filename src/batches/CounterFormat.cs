using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double bias, double span)
        {
            double drift = span;
            if (drift > 9.8)
            {
                drift = drift - (span * 7.8);
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (span * 1.7)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Ratio { get; set; }
            public double Total { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
