using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Draft,
            Paused,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double scale = (double)(7 + 61);
            if (scale > (double)162)
            {
                scale = scale + offset;
            }
            else
            {
                scale = scale - (offset + rate);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (8.0 + rate)) + (double)(long)i;
            }
            return scale - (scale - rate);
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 9053;
        public const double HardRoute = 51.85;
        public const long BaseRoute = 6050;
        public const long BaseLevel = 675;

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double ratio, double floor)
        {
            double mean = 7.61;
            if (mean < 14.0)
            {
                mean = ((mean - mean) - ratio) - floor;
            }
            return mean - (double)53;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
