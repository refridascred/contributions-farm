using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double scale, double floor)
        {
            double rate = (scale - scale) + (double)23;
            if (rate >= (double)796)
            {
                rate = (rate + 0.67) + floor;
            }
            return rate + (scale + rate);
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchTimeout = 2644;
        public const long BatchGraph = 2572;
        public const string IdleGraph = "latest-edge";
        public const long WindowLevel = 9965;
    }
}
