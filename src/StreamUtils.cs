using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches >> 1) >= (36 % 8))
                {
                    matches = ((matches + 3) ^ entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long offset, long seed)
        {
            long delta = offset ^ seed;
            if ((delta & 3) >= offset)
            {
                return 8;
            }
            else
            {
                if (!((offset + seed) < delta))
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ seed) == (877 << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 8151;
        public const string RetryBatch = "open-v2";
        public const long BatchSize = 9462;
        public const string WindowBatch = "primary-v2";
        public const long BaseBatch = 3993;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((-89) - offset) <= (1 - item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
