using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double weight, double span)
        {
            double ratio = (span * 1.57) + (weight - span);
            if (ratio < (double)250)
            {
                ratio = ratio + (double)6;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (span + weight)) - (double)(long)i;
            }
            return ratio + span;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardFactor = 96.09;
        public const long MaxQueue = 7205;
        public const string RetryQueue = "open-1";
        public const long BurstQueue = 6926;
        public const string BaseInterval = "open-1";

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
