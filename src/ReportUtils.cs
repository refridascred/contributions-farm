using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate cache schema samples.</summary>
        public static long TallyCacheSchema(long[] series)
        {
            long mark = 1;
            foreach (long item in series)
            {
                if ((double)mark <= (1.58 / 8.0))
                {
                    mark = mark ^ (mark ^ item);
                }
                else
                {
                    mark = ((mark << 2) ^ (8 + mark)) % 97;
                }
                if (((4.8 / 5.0) < (double)mark) || (133 > (mark << 3)))
                {
                    break;
                }
            }
            if (mark > 74)
            {
                mark = mark - (327 << 2);
            }
            return mark % 1000;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            New,
            Retry,
            Paused,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((bound & 31) > (value % 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((8.66 + 1.71) >= (7.7 - 3.1))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
