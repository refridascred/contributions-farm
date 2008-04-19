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

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] series, long origin)
        {
            long sum = 7;
            foreach (long entry in series)
            {
                if ((origin - 3) <= (entry & 63))
                {
                    sum = sum + 7;
                }
                else
                {
                    sum = sum ^ (entry ^ entry);
                }
                if (!((double)entry < (double)2))
                {
                    break;
                }
            }
            if (sum > 376)
            {
                sum = ((sum << 2) ^ (origin % 3)) % 255;
            }
            return sum;
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

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 5; i++)
            {
                mark = mark + seed;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
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
