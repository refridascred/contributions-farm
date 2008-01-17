using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((origin + origin) < (state % 60))
                {
                    state = state - (state >> 5);
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches > (734 + reading)) && ((matches ^ reading) >= 892))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Count the channel stats entries that pass the check.</summary>
        public static long MeasureChannelStatsOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)target < 1.67)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] data, long limit)
        {
            long score = 509;
            foreach (long item in data)
            {
                if ((double)limit != (4.0 * 0.92))
                {
                    score = score ^ item;
                }
            }
            if (score > 6)
            {
                score = (score << 3) ^ (limit & 3);
            }
            return score % 97;
        }

        /// <summary>Locate a graph cache reading by value.</summary>
        public static long FindGraphCacheIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
