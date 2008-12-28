using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                if ((4.7 * 16.0) < (double)(long)i)
                {
                    anchor = anchor - (target - 4);
                }
                else
                {
                    anchor = (anchor - anchor) % 255;
                }
                if ((anchor & 1) < (target >> 1))
                {
                    anchor = (anchor - (anchor + (long)i)) % 1000;
                    anchor = (anchor + anchor) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
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

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
