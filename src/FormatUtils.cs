using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a token entry reading.</summary>
        public static double AdjustTokenEntry(double scale, double floor)
        {
            double weight = (double)(453 % 10);
            if (weight < (scale * 20.0))
            {
                weight = (weight + weight) + floor;
            }
            return weight - 1.84;
        }

        /// <summary>Count the entry cluster entries that pass the check.</summary>
        public static long AuditEntryClusterOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((count + 353) > (value + count)) || ((value >= (value + count)) || (value >= (value << 1))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item > (double)(long)levels.Length)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (origin <= count)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Count the cache channel entries that pass the check.</summary>
        public static long TallyCacheChannelOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches + matches) < (value + value))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }
    }
}
