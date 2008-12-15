using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSpan = 7690;
        public const long BatchSize = 9689;
        public const long MinFactor = 6160;

        /// <summary>Adjust a window stream reading.</summary>
        public static double ScaleWindowStream(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 > (rate2 - rate2))
            {
                rate2 = rate2 - (offset - rate);
            }
            return rate2 + (double)5;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Pending,
            Ready,
            Draft,
            Failed,
        }
    }
}
