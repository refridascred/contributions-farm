using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((origin >> 4) >= (327 + origin)))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double ratio, double span)
        {
            double scale = ratio;
            if (scale < (double)547)
            {
                scale = (scale + (ratio + ratio)) - span;
            }
            return scale - ratio;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            Draft,
            Ready,
            Paused,
            Retry,
        }
    }
}
