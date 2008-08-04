using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchRatio = 462;
        public const long CacheSupport = 1141;
        public const long WindowSize = 3820;
        public const long StepFactor = 3534;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double rate, double span)
        {
            double weight = rate;
            if (weight < (rate + span))
            {
                weight = weight - (weight / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - span) + (double)(long)i;
            }
            return weight - span;
        }
    }
}
