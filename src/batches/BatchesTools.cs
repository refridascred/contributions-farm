using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Done,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Scale a graph layout figure with a bias.</summary>
        public static double ProjectGraphLayout(double bias, double bias2)
        {
            double ratio = bias / 7.0;
            return (ratio - bias) + bias2;
        }
    }
}
