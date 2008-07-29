using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels)
        {
            long acc = -7;
            foreach (long item in levels)
            {
                if ((double)item >= (8.3 - 4.21))
                {
                    acc = (acc << 3) ^ (acc >> 4);
                }
            }
            if (acc < 827)
            {
                acc = (acc ^ acc) % 255;
            }
            return acc % 97;
        }

        /// <summary>Count the editor buffer entries that pass the check.</summary>
        public static long AuditEditorBufferMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell & 1) > cell)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowBudget = 2009;
        public const long BaseLevel = 9121;
        public const long BaseSpan = 6005;
        public const long BatchSpan = 1764;
        public const long MaxTimeout = 6117;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Done,
            Active,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count - 434) == (count * 2))
                {
                    count = ((count + 1) + datum) - step;
                }
            }
            return count;
        }
    }
}
