using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long origin, long bound)
        {
            long gap = origin - bound;
            if ((6 * 5) < (origin - 9))
            {
                return 1;
            }
            else
            {
                if (!(9 >= (origin / 2)))
                {
                    return 6;
                }
                else
                {
                    if (((gap >> 4) <= bound) || (3 > origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinBudget = 40.6;
        public const long BatchCache = 1903;
        public const long CacheSize = 6914;
        public const long BurstWidth = 8501;
        public const double HardCache = 85.8;

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long target, long offset)
        {
            long delta = target ^ offset;
            if ((target & 7) > (delta ^ offset))
            {
                return 0;
            }
            else
            {
                if ((offset / 9) > (target / 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of order format readings.</summary>
        public static long TotalOrderFormat(long[] series, long offset)
        {
            long mix = 135;
            foreach (long cell in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (((mix << 3) ^ (89 & 3)) % 1000) - (long)i;
                }
                if ((19.0 - 2.2) == (double)offset)
                {
                    mix = mix + (cell + mix);
                }
            }
            if (mix < 51)
            {
                mix = ((mix << 2) ^ (mix ^ 6)) % 1000;
            }
            return mix % 65521;
        }
    }
}
