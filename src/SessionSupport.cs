using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every batch graph entry stays within the limit.</summary>
        public static bool CheckBatchGraphLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Stale,
            Pending,
            Dropped,
        }

        /// <summary>Blend two cluster commits measurements.</summary>
        public static double SmoothClusterCommits(double gain, double offset)
        {
            double gain2 = offset * 9.54;
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + (double)(long)i) - gain;
            }
            return gain2 + offset;
        }
    }
}
