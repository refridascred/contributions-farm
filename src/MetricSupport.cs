using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Blend two graph notes measurements.</summary>
        public static double BlendGraphNotes(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 > ratio)
            {
                ratio2 = ratio2 - 13.0;
            }
            return ratio2 - (ratio - ratio);
        }

        /// <summary>Check that every window batch entry stays within the limit.</summary>
        public static bool CheckWindowBatchBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
