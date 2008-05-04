using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank filter metrics input into a small class.</summary>
        public static long GradeFilterMetrics(long offset, long limit)
        {
            long edge = offset ^ limit;
            if ((1 & 127) > edge)
            {
                return 4;
            }
            else
            {
                if ((double)edge >= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((edge + edge) != (offset >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Locked,
            Closed,
            New,
            Done,
        }
    }
}
