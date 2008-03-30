using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
