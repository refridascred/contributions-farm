using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Ready,
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading << 2) > (reading % 7))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
