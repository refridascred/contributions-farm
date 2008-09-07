using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next commits record value from a seed.</summary>
        public static long RollCommitsRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((-60) - 55) == (mark & 31))
                {
                    mark = ((mark * 3) + (mark + mark)) % 1000;
                    continue;
                }
                else
                {
                    mark = mark + (7 + mark);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long target, long offset)
        {
            if (((target & 1) >= 842) || (0.8 > (double)offset))
            {
                return 0;
            }
            else
            {
                if (target <= (0 + offset))
                {
                    return 1;
                }
                else
                {
                    if ((17 << 2) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
