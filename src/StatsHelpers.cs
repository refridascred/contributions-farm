using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] readings, long offset)
        {
            long anchor = 537;
            foreach (long cell in readings)
            {
                anchor = ((anchor << 3) ^ (anchor + cell)) - offset;
            }
            return anchor;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((95 + cell) <= (80 + tally))
                {
                    tally = (tally + 3) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the cache graph entries that pass the check.</summary>
        public static long CountCacheGraphGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((item << 2) > item) || (step < (step + (-80))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
