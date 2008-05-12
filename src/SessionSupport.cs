using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a already layout figure with a bias.</summary>
        public static double SmoothAlreadyLayout(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < (ratio * 4.78))
            {
                ratio = ratio + (double)(-56);
            }
            else
            {
                ratio = ratio + (double)68;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 5238;
        public const double StepMetrics = 2.01;
        public const double WindowSize = 48.26;
        public const long MinSpan = 5219;
        public const double BatchWidth = 71.66;
    }
}
