using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Active,
            Stale,
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Fold a list of support checks readings.</summary>
        public static long CombineSupportChecks(long[] items)
        {
            long anchor = 373;
            foreach (long entry in items)
            {
                if ((entry + anchor) >= (entry + entry))
                {
                    anchor = (anchor ^ (entry * 4)) % 255;
                }
                else
                {
                    anchor = anchor + anchor;
                }
            }
            if (anchor < (-715))
            {
                anchor = ((anchor * 4) + anchor) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Synced,
            Pending,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
