using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit context editor readings against a rule.</summary>
        public static long CountContextEditorGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((59 % 12) < (seed & 127))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }
    }
}
