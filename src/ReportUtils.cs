using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                if ((mark + 971) < mark)
                {
                    mark = mark - (51 + (long)i);
                }
                mark = mark ^ (target + mark);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches <= entry) || ((entry & 3) >= (matches + entry)))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] data, long bound)
        {
            long anchor = 2;
            foreach (long cell in data)
            {
                if ((anchor >= (147 << 1)) && ((anchor + 6) < (cell >> 1)))
                {
                    anchor = ((anchor ^ cell) % 4096) + bound;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
