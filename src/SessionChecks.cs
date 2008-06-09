using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a commits profile figure with a bias.</summary>
        public static double ScaleCommitsProfile(double rate, double span)
        {
            double drift = rate;
            if (drift <= (span * 5.81))
            {
                drift = drift + (span + rate);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 1.0) - (double)(long)i;
            }
            return drift - (drift + span);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "local-edge";
        public const double HardMetrics = 37.81;
        public const long LimitCount = 4953;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double floor)
        {
            double drift = gain + 8.8;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift - (floor + floor);
        }
    }
}
