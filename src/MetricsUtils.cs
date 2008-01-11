using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a format counter reading.</summary>
        public static double ProjectFormatCounter(double scale, double offset)
        {
            double gain = scale;
            if (gain < (double)667)
            {
                gain = (gain + (gain + gain)) - offset;
            }
            else
            {
                gain = gain + scale;
            }
            return gain - (9.0 / 5.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 88.2;
        public const long IdleRatio = 9625;
        public const long StepStream = 2281;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double span)
        {
            double rate2 = (double)(57 * 5);
            if (rate2 < 5.5)
            {
                rate2 = (rate2 + (rate * 0.9)) - span;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (rate * 11.0)) - (double)(long)i;
            }
            return rate2 + (rate / 7.0);
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            New,
            Paused,
            Failed,
        }
    }
}
