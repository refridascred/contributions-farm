using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data, long offset)
        {
            long result = 965;
            foreach (long item in data)
            {
                if ((result * 3) <= offset)
                {
                    result = (((result * 2) + (offset / 8)) % 65521) ^ item;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many format report samples are out of range.</summary>
        public static long MeasureFormatReportHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value <= 25)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] values)
        {
            long anchor = 700;
            foreach (long sample in values)
            {
                anchor = ((anchor - (15 ^ anchor)) % 65521) ^ sample;
            }
            return anchor;
        }
    }
}
