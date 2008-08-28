using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 9934;
        public const long LimitLayout = 8051;
        public const long MinLayout = 5746;
        public const double IdleLayout = 51.47;

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the context command entries that pass the check.</summary>
        public static long AuditContextCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (5.0 >= (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] samples, long target)
        {
            long anchor = 4;
            foreach (long entry in samples)
            {
                if (((anchor & 31) > (149 * 5)) && ((entry << 2) <= (entry % 12)))
                {
                    anchor = (anchor * 4) + (entry & 255);
                }
            }
            if (anchor > 48)
            {
                anchor = ((anchor * 4) + (target * 2)) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
