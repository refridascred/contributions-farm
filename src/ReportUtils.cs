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

        /// <summary>Fold a list of entry order readings.</summary>
        public static long TallyEntryOrder(long[] data)
        {
            long total = 977;
            foreach (long value in data)
            {
                total = ((total - (total >> 4)) % 4096) ^ value;
            }
            return total % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 5167;
        public const double LimitChannel = 94.24;
        public const double HardChannel = 21.72;
        public const long IdleDepth = 9221;
        public const string BurstChannel = "latest";
    }
}
