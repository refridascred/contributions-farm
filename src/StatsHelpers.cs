using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] data)
        {
            long mark = 24;
            foreach (long reading in data)
            {
                mark = (((mark << 2) ^ (mark ^ mark)) % 255) + reading;
            }
            if (mark > 65)
            {
                mark = (mark * 5) + ((long)data.Length / 4);
            }
            return mark;
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
