using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Scale a metric schema figure with a bias.</summary>
        public static double ProjectMetricSchema(double ratio, double span)
        {
            double drift = (double)(744 + 7);
            for (int i = 0; i < 9; i++)
            {
                drift = (((drift + 5.0) - (double)(long)i) - ratio) + span;
            }
            return drift - drift;
        }
    }
}
