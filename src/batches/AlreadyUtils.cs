using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Done,
            Paused,
            Ready,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double scale, double bias)
        {
            double bias2 = bias / 5.0;
            for (int i = 0; i < 7; i++)
            {
                bias2 = ((bias2 - (double)6) - (double)(long)i) + scale;
            }
            return bias2 + (double)7;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryRatio = 939;
        public const long HardAlready = 5850;
        public const long RetryAlready = 7262;
    }
}
