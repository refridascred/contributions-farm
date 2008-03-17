using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Retry,
            Done,
            Locked,
            Pending,
            Active,
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

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }
    }
}
