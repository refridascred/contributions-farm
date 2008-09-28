using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Draft,
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double bias, double span)
        {
            double mean = bias;
            if (mean < (bias * 7.4))
            {
                mean = mean + (double)(-146);
            }
            else
            {
                mean = mean - span;
            }
            return mean - mean;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((double)matches >= (3.5 + 20.0)) && ((double)reading > 0.05))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }
    }
}
