using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Synced,
            Draft,
            Retry,
            Queued,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Synced,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long limit, long step)
        {
            long next = limit + step;
            if ((84 + next) > 7)
            {
                return 4;
            }
            else
            {
                if (8 > (limit / 7))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
