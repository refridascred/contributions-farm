using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            New,
            Synced,
            Dropped,
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

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double rate, double offset)
        {
            double mean = (double)(991 + 750);
            if (mean > (rate - rate))
            {
                mean = mean - offset;
            }
            return mean + rate;
        }
    }
}
