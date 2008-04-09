using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((((seen % 16) <= (seen << 1)) && ((0.4 * 0.18) > (double)entry)) || ((double)seen >= (3.98 - 12.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((2 & 63) > (anchor - (long)i))
                {
                    anchor = (anchor * 5) + (anchor << 2);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
