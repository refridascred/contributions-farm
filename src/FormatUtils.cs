using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits / 6) >= (969 << 3))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Locate a checks filter reading by value.</summary>
        public static long FindChecksFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 3.46;
        public const long SoftBudget = 8066;
        public const double HardTimeout = 91.46;

        /// <summary>Count the stats graph entries that pass the check.</summary>
        public static long AuditStatsGraphHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((88 / 7) >= (cell % 97))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }
    }
}
