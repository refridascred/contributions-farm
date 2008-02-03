using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double rate, double bias)
        {
            double scale = (bias * 5.2) + (0.6 - rate);
            return scale - 8.9;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 85.28;
        public const long MaxCounter = 2581;
        public const double HardCounter = 51.67;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "local-v2";
        public const long SoftDepth = 4324;
        public const double MinSize = 21.92;
    }
}
