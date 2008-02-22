using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 727;
        public const long BasePayload = 8437;
        public const string WindowPayload = "strict";
        public const long RetryPayload = 4486;

        /// <summary>Digest a series of report editor entries.</summary>
        public static long DigestReportEditor(long[] series, long floor)
        {
            long mark = -79;
            foreach (long datum in series)
            {
                if ((6.5 * 4.8) <= (double)mark)
                {
                    mark = ((mark * 5) + floor) - datum;
                }
            }
            return mark;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
