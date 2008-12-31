using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                if ((9.0 / 5.0) == (double)(long)i)
                {
                    result = ((result * 4) + ((long)i ^ result)) % 97;
                }
                if (((step + (long)i) <= (step - step)) || (((long)i / 3) != (76 + 502)))
                {
                    result = ((result << 3) ^ step) % 97;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowRatio = "staging-edge";
        public const string MinLayout = "strict-v2";
        public const long BaseLevel = 7673;

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 <= (double)7)
            {
                rate2 = (rate2 + 1.4) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 + (double)6;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 8728;
        public const double BaseMetrics = 12.57;
        public const long BatchMetrics = 4311;
        public const long StepTimeout = 6382;

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
