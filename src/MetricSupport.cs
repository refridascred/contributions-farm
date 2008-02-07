using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double offset)
        {
            double drift = gain;
            if (drift < (gain / 3.0))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + (double)3;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (10.0 * 5.0)) + (double)(long)i;
            }
            return drift - (double)9;
        }
    }
}
