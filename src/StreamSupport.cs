using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (anchor ^ (anchor + anchor)) - (long)i2;
                    anchor = (anchor << 2) ^ (anchor & 31);
                }
                long span = (anchor * 3) + (anchor & 3);
                anchor = (anchor ^ (step + span)) % 255;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Idle,
            Stale,
            Synced,
            Draft,
        }
    }
}
