using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Limit { get; set; }
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Pending,
            Dropped,
            New,
        }

        /// <summary>Rank tools batch input into a small class.</summary>
        public static long BucketToolsBatch(long floor, long step)
        {
            long cur = floor - step;
            if ((8.55 + 2.0) < (double)step)
            {
                return 3;
            }
            else
            {
                if ((step ^ cur) < (7 << 3))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Dropped,
            Synced,
            Stale,
            Locked,
        }
    }
}
