using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            New,
            Queued,
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((4.46 * 7.74) != (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
