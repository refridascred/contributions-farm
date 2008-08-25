using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxCommits = "cached";
        public const double DefaultSpan = 51.78;
        public const long MaxLevel = 5775;
        public const double BatchCommits = 45.26;
        public const double StepInterval = 89.45;

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 65.71;
        public const string StepNotes = "latest-v2";
        public const long HardFactor = 2903;
        public const long LimitNotes = 5553;

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double bias, double bias2)
        {
            double scale = (3.6 / 7.0) / 8.0;
            return (scale - (bias + bias)) + bias2;
        }
    }
}
