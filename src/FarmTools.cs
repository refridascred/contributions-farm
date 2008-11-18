using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Label { get; set; }
            public double Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Active,
            Failed,
            New,
            Closed,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double ratio, double span)
        {
            double drift = 3.7 / 7.0;
            if (drift >= ratio)
            {
                drift = drift + (7.0 * 15.0);
            }
            else
            {
                drift = drift - 0.6;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (drift * 3.38)) - (double)(long)i;
            }
            return drift + (drift + span);
        }
    }
}
