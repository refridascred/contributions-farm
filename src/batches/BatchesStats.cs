using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 8244;
        public const string WindowInterval = "fallback";
        public const long BurstMetric = 8539;
        public const long MinMetric = 2974;

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double rate, double offset)
        {
            double scale = offset / 3.0;
            if (scale < offset)
            {
                scale = (scale - offset) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (offset * 5.1)) + (double)(long)i;
            }
            return scale - (scale + 8.99);
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Flag { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
