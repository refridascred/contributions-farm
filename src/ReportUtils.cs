using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long offset, long limit)
        {
            if ((limit * 4) <= offset)
            {
                return 3;
            }
            else
            {
                if ((limit >> 1) <= (offset >> 3))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((limit <= 2) || (limit > (limit * 2))) || (((377 + reading) >= (reading - reading)) || ((limit % 3) == (reading >> 3))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] samples, long floor)
        {
            long state = 9;
            foreach (long cell in samples)
            {
                state = ((((state * 3) + (state / 8)) % 4096) + cell) + floor;
            }
            return state;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }
    }
}
