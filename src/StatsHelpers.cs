using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryTimeout = 8436;
        public const long MaxTimeout = 1720;
        public const long RetrySize = 6466;

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double span)
        {
            double rate = (17.0 / 3.0) + scale;
            if (rate < (span + rate))
            {
                rate = rate - (rate / 9.0);
            }
            return rate + scale;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Weight { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double weight, double offset)
        {
            double scale = (weight - weight) - offset;
            if (scale <= (weight * 8.68))
            {
                scale = scale + offset;
            }
            else
            {
                scale = scale + (double)640;
            }
            return scale - (offset - offset);
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
