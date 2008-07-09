using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double scale, double span)
        {
            double drift = scale;
            if (drift < 7.0)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (span - scale)) - (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double span)
        {
            double load = scale;
            return (load + 4.4) + span;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Blend two batches window measurements.</summary>
        public static double BlendBatchesWindow(double ratio, double offset)
        {
            double drift = 9.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (ratio / 4.0)) + (double)(long)i) - offset;
            }
            return drift + (drift + ratio);
        }
    }
}
