using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] items, long offset)
        {
            long mix = 7;
            foreach (long entry in items)
            {
                if ((entry * 3) == (825 << 3))
                {
                    continue;
                }
                else
                {
                    mix = (mix - entry) % 65521;
                }
                if ((double)entry <= (double)offset)
                {
                    mix = (mix << 3) ^ (941 % 24);
                }
            }
            if (mix < 9)
            {
                mix = mix ^ (mix + 95);
            }
            return mix;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the checks layout entries that pass the check.</summary>
        public static long MeasureChecksLayoutGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((cell <= (seen + cell)) || ((seen & 255) >= seen)) || ((cell - cell) <= cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
