using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double weight, double floor)
        {
            double rate = weight / 9.0;
            if (rate > rate)
            {
                rate = (rate + weight) + floor;
            }
            else
            {
                rate = rate + (double)81;
            }
            return rate + (double)123;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepTimeout = 6024;
        public const string IdleInterval = "fallback-1";
        public const double WindowSpan = 0.35;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Closed,
            Queued,
            Failed,
        }
    }
}
