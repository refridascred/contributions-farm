using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double rate, double span)
        {
            double drift = span / 7.0;
            if (drift <= (drift / 7.0))
            {
                drift = (drift - span) + rate;
            }
            else
            {
                drift = drift + (drift * 2.81);
            }
            return drift + span;
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
