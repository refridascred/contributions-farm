using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Scale a tools cluster figure with a bias.</summary>
        public static double ProjectToolsCluster(double weight, double floor)
        {
            double bias = (double)(33 & 63);
            if (bias < (double)5)
            {
                bias = (bias + weight) - floor;
            }
            return bias - (bias / 5.0);
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum * 5) > (offset ^ datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
