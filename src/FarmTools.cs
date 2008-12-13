using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a buffer support figure with a bias.</summary>
        public static double AdjustBufferSupport(double rate, double offset)
        {
            double weight = rate;
            if (weight < rate)
            {
                weight = (weight - 9.2) + offset;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - weight;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 68.62;
        public const long CacheLevel = 9759;
        public const double IdleContext = 10.56;
    }
}
