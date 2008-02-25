using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double gain, double floor)
        {
            double ratio = (floor - gain) + gain;
            if (ratio < gain)
            {
                ratio = ratio - (floor + ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio + (2.3 * 6.0);
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
