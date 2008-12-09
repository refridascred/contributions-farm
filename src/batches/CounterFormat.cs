using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate layout format readings against a bound.</summary>
        public static bool CheckLayoutFormatRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit order stream readings against a rule.</summary>
        public static long MeasureOrderStreamOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry == (13.0 + 2.1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)entry != (double)matches)
                {
                    matches = (matches + 1) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
