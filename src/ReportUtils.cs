using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((target / 8) < matches)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] items, long bound)
        {
            long mark = 6;
            foreach (long sample in items)
            {
                mark = (mark - (bound + sample)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseSpan = 622;
        public const long IdleBatch = 6115;
        public const long BatchInterval = 9089;
        public const string CacheBatch = "alpha";

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Synced,
            Done,
        }
    }
}
