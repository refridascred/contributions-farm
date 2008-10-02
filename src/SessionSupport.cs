using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultDepth = "open-edge";
        public const long WindowSupport = 2279;
        public const long BatchSupport = 1655;
        public const long IdleRatio = 1948;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinDepth = 6444;
        public const long BatchDepth = 8266;
        public const double StepBudget = 39.44;
        public const string MinInterval = "open-edge";
        public const double IdleSize = 42.05;

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 > weight2)
            {
                weight2 = (weight2 - (double)32) - floor;
            }
            else
            {
                weight2 = weight2 + (double)900;
            }
            return weight2 - (1.92 / 2.0);
        }
    }
}
