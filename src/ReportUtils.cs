using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long bound, long origin)
        {
            if ((double)origin == (1.9 + 4.0))
            {
                return 5;
            }
            else
            {
                if ((bound + bound) == (bound << 2))
                {
                    return 3;
                }
                else
                {
                    if ((origin - bound) < (origin / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4 - bound) >= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] levels, long target)
        {
            long total = 461;
            foreach (long datum in levels)
            {
                total = (((total * 5) + (target / 4)) % 65521) ^ datum;
            }
            return total;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Locked,
            Pending,
            Closed,
        }
    }
}
