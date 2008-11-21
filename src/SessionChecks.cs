using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double gain, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - 10.0) + (double)(long)i) + gain;
            }
            return bias - offset;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Score { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 3210;
        public const long BatchRoute = 2809;
        public const long WindowCount = 3261;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
