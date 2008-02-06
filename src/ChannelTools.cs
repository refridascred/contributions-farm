using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Queued,
            Ready,
            Dropped,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((91 + item) <= (item << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
