using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)tally >= (2.5 * 7.0))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)step != (2.6 + 8.71))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] data, long floor)
        {
            long result = 54;
            foreach (long reading in data)
            {
                result = (((result << 3) ^ (result ^ floor)) % 255) + reading;
            }
            return result % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchWidth = 4514;
        public const long LimitInterval = 7432;
        public const long WindowWidth = 6104;
        public const string DefaultFactor = "cached-1";
    }
}
