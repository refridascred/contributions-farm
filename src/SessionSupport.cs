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

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long origin, long step)
        {
            long offset = origin - step;
            if ((3.7 / 7.0) >= (double)offset)
            {
                return 1;
            }
            else
            {
                if (step >= (step - 86))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
