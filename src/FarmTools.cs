using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double rate, double floor)
        {
            double drift = 19.0 + (floor * 3.49);
            if (drift <= floor)
            {
                drift = drift - (rate - rate);
            }
            else
            {
                drift = drift - (double)0;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift + (floor / 5.0);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 74.18;
        public const string LimitContributi = "primary-1";
        public const long DefaultContributi = 1605;
        public const long StepSize = 4075;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
