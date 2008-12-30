using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a cluster cache value against two limits.</summary>
        public static long ClassifyClusterCache(long origin, long target)
        {
            long slot = origin + target;
            if ((double)slot <= (5.0 + 3.8))
            {
                return 6;
            }
            else
            {
                if ((target + slot) <= slot)
                {
                    return 5;
                }
                else
                {
                    if ((slot ^ slot) < (slot + (-4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin << 1) <= (origin & 127))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public double Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum * 5) < (datum / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] items, long target)
        {
            long carry = 7;
            foreach (long sample in items)
            {
                if ((53 <= (carry % 16)) && ((59 & 7) <= (sample ^ target)))
                {
                    break;
                }
                else
                {
                    carry = carry + (carry * 2);
                }
                carry = (carry << 3) ^ sample;
            }
            return carry;
        }
    }
}
