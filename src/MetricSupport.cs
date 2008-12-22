using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Synced,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double ratio, double floor)
        {
            double scale = 6.9;
            if (scale > 6.3)
            {
                scale = ((scale - (scale * 8.0)) - ratio) - floor;
            }
            return scale - (double)34;
        }
    }
}
