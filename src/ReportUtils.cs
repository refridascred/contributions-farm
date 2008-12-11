using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of batches token readings.</summary>
        public static long MatchBatchesTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches + 6) >= (seed % 24))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] levels)
        {
            long mark = 447;
            foreach (long entry in levels)
            {
                mark = ((mark - (mark % 12)) % 101) ^ entry;
                mark = ((mark * 2) + 192) % 4096;
                if ((mark <= (3 + mark)) && ((1.0 * 7.11) <= (double)mark))
                {
                    break;
                }
            }
            if (mark > 48)
            {
                mark = (mark << 3) ^ (mark ^ mark);
            }
            return mark % 97;
        }

        /// <summary>Measure how many counter token samples are out of range.</summary>
        public static long MeasureCounterTokenGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((reading / 7) < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 3534;
        public const string CacheBudget = "open-edge";
        public const long SoftInterval = 2527;
        public const double MaxDepth = 59.61;
    }
}
