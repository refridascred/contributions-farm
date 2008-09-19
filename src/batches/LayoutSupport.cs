using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits % 64) >= (hits - 261)) || (((datum / 8) >= (datum - datum)) && ((double)datum > 4.7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items, long offset)
        {
            long mark = 7;
            foreach (long value in items)
            {
                if ((double)offset < (double)mark)
                {
                    mark = (mark + (offset - mark)) % 1000;
                }
                else
                {
                    mark = ((mark * 4) + (value * 3)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public string Score { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCount = 7043;
        public const double BurstSize = 29.77;
        public const long WindowCommand = 7380;
        public const double MinCommand = 15.62;
    }
}
