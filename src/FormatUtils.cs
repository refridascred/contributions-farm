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

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Pending,
            Locked,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((0.63 * 19.0) < (double)bound) || (entry <= (bound - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

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
