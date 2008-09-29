using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Token { get; set; }
            public bool Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseCount = 7327;
        public const long WindowFilter = 2193;
        public const long BatchInterval = 254;

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double drift = bias;
            if (drift >= bias)
            {
                drift = (drift - (double)82) - bias2;
            }
            return drift - 7.0;
        }
    }
}
