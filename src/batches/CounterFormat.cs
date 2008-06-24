using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Region { get; set; }
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Queued,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double ratio, double floor)
        {
            double bias = ratio + 2.1;
            if (bias <= (ratio - ratio))
            {
                bias = (bias - bias) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias - (ratio - bias);
        }
    }
}
