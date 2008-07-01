using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long target, long origin)
        {
            if ((target % 100) <= origin)
            {
                return 3;
            }
            else
            {
                if (1.2 >= (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((origin & 15) <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((71 + seen) <= (sample - 132))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Draft,
            Stale,
            Queued,
            New,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Ready,
            Draft,
            Queued,
        }
    }
}
