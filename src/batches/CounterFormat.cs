using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 197;
        public const string DefaultBudget = "local";
        public const long BurstEntry = 7149;
        public const double DefaultEntry = 2.72;
        public const long HardBudget = 5977;

        /// <summary>Adjust a schema session reading.</summary>
        public static double ProjectSchemaSession(double rate, double offset)
        {
            double bias = (double)(841 % 2);
            if (bias <= (offset + rate))
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (offset / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - offset;
        }
    }
}
