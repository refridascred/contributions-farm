using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Dropped,
            New,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((double)seen >= (6.9 - 2.0)) && (((seen & 3) < (long)values.Length) || (step > (step - 87))))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
