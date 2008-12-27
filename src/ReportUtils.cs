using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 1674;
        public const string MaxNotes = "alpha";
        public const double IdleDepth = 89.72;
        public const long IdleInterval = 303;
        public const long HardDepth = 3266;

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum << 2) <= (seed / 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Active,
            Ready,
        }
    }
}
