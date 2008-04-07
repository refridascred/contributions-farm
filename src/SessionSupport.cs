using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((item - hits) >= (limit & 63)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Stale,
            Locked,
            Synced,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double gain, double offset)
        {
            double drift = gain - (double)19;
            if (drift > 9.0)
            {
                drift = drift + (gain - gain);
            }
            else
            {
                drift = drift + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + offset;
        }
    }
}
