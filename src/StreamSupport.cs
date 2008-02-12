using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits * 3) < (sample ^ step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long limit, long target)
        {
            if ((target - 8) <= (606 / 7))
            {
                return 7;
            }
            else
            {
                if ((double)limit <= (3.0 * 2.68))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit < (2.1 * 1.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
