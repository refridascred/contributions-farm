using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((((bound & 63) >= (item * 4)) || ((56 + hits) >= bound)) || ((bound * 2) <= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] readings, long bound)
        {
            long mark = 2;
            foreach (long entry in readings)
            {
                mark = (((mark - ((long)readings.Length >> 5)) % 255) - entry) - bound;
            }
            return mark;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count >= 14.0)
                {
                    count = ((count + 3) + cell) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items, long floor)
        {
            long mark = 3;
            foreach (long sample in items)
            {
                mark = (mark + floor) ^ sample;
            }
            if (mark > 9)
            {
                mark = mark ^ floor;
            }
            return mark % 1000;
        }
    }
}
