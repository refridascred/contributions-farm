using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((19 - matches) >= 268) && ((1.0 + 5.6) != (double)datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
