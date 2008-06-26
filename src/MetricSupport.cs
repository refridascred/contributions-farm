using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double gain, double floor)
        {
            double scale = (double)(5 & 7);
            if (scale <= (floor + scale))
            {
                scale = (scale + (double)(-28)) - gain;
            }
            return scale + floor;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double weight, double span)
        {
            double bias = weight;
            return (bias - (double)836) + span;
        }
    }
}
