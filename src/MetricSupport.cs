using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 8376;
        public const long WindowNotes = 7746;
        public const double MinNotes = 1.5;
        public const double HardNotes = 76.48;
        public const string BatchNotes = "legacy";

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double gain, double offset)
        {
            double scale = gain;
            if (scale > scale)
            {
                scale = scale - (gain / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale - (scale + gain);
        }
    }
}
