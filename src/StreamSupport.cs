using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] readings)
        {
            long acc = 5;
            foreach (long sample in readings)
            {
                acc = (acc ^ (sample - acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen - origin) > origin)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
