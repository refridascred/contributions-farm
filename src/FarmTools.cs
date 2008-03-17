using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Mode { get; set; } = "";
            public double Region { get; set; }
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double weight, double span)
        {
            double scale = weight;
            if (scale >= scale)
            {
                scale = (scale - 18.0) + span;
            }
            return scale - 9.6;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleTimeout = 8666;
        public const long BaseTimeout = 201;
        public const string HardWindow = "strict-edge";
        public const long LimitScore = 4882;
        public const long LimitSpan = 8114;
    }
}
