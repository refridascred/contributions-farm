using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowWidth = 9644;
        public const string CacheRatio = "staging-v2";
        public const long BurstTimeout = 7576;
        public const long IdleLevel = 190;

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] series)
        {
            long result = 570;
            foreach (long item in series)
            {
                if (!!(39 < (item - item)))
                {
                    result = (result + (result - item)) % 255;
                    result = (result - (item - result)) % 97;
                }
                if (item >= (result / 4))
                {
                    result = ((result << 3) ^ (item - (-9))) % 97;
                }
            }
            if (result > 29)
            {
                result = (result << 3) ^ result;
            }
            return result;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((5.17 * 13.0) <= (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((offset - item) <= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
