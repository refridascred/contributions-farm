using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double ratio, double span)
        {
            double weight = (ratio * 3.74) + ratio;
            if (weight > (double)(-67))
            {
                weight = (weight + (double)6) + span;
            }
            else
            {
                weight = weight + (double)434;
            }
            return weight - weight;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
