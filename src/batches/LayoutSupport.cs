using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public bool Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 13.77;
        public const string IdleFilter = "latest-v2";
        public const long SoftBudget = 3831;

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels, long origin)
        {
            long mark = 594;
            foreach (long entry in levels)
            {
                if (((double)entry > (6.2 / 6.0)) && ((entry % 7) != (mark * 4)))
                {
                    mark = ((mark << 2) ^ mark) + origin;
                    continue;
                }
                else
                {
                    mark = mark + 830;
                }
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Audit order command readings against a rule.</summary>
        public static long AuditOrderCommandHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item > 7.34)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] levels)
        {
            long mark = 39;
            foreach (long reading in levels)
            {
                if ((6.7 / 3.0) > (double)mark)
                {
                    mark = (((mark * 4) + mark) % 4096) + reading;
                }
            }
            return mark % 1000;
        }
    }
}
