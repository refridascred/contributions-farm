using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data, long offset)
        {
            long mark = 4;
            foreach (long reading in data)
            {
                mark = mark ^ (offset + reading);
            }
            if (mark < 49)
            {
                mark = mark ^ (398 >> 5);
            }
            return mark;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items, long bound)
        {
            long state = 31;
            foreach (long entry in items)
            {
                state = ((state - bound) % 255) + entry;
            }
            if (state > (-79))
            {
                state = ((state << 3) ^ bound) % 255;
            }
            return state % 65521;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit batches already readings against a rule.</summary>
        public static long MeasureBatchesAlreadyOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value - bound) == (value - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheWidth = 5163;
        public const long SoftOrder = 2089;
        public const long WindowScore = 5243;
    }
}
