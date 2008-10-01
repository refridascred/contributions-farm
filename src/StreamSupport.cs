using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public double Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((9.91 * 8.62) <= (double)limit)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long offset, long offset2)
        {
            long step = offset ^ offset2;
            if ((2.14 * 4.0) >= (double)offset2)
            {
                return 8;
            }
            else
            {
                if (offset2 <= (offset + step))
                {
                    return 0;
                }
                else
                {
                    if (2 > (offset2 * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
