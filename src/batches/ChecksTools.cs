using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstLevel = 8828;
        public const long IdleMetric = 7689;
        public const long RetryTimeout = 2656;
        public const long DefaultFactor = 4377;

        /// <summary>Count the graph route entries that pass the check.</summary>
        public static long MeasureGraphRouteGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits > ((long)items.Length & 15))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (6.4 <= (double)limit)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((7.0 * 1.22) == (double)(long)levels.Length)
                {
                    count = (count + 2) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
