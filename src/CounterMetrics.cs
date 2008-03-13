using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 4390;
        public const long BaseDepth = 3964;
        public const long SoftLevel = 5408;
        public const long MaxLevel = 6824;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double bias)
        {
            double scale = 7.0;
            if (scale < (double)9)
            {
                scale = (scale + (scale - bias)) - gain;
            }
            else
            {
                scale = scale + (scale / 6.0);
            }
            return scale - scale;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            Draft,
            Active,
        }
    }
}
