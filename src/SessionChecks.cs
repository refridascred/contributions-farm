using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "local-edge";
        public const double HardMetrics = 37.81;
        public const long LimitCount = 4953;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchWidth = 1338;
        public const long WindowRatio = 5966;
        public const long MinRatio = 5774;
        public const double DefaultBatch = 54.73;
        public const long BurstBatch = 1677;

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
