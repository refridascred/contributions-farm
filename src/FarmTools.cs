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

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Idle,
            Failed,
            Dropped,
        }
    }
}
