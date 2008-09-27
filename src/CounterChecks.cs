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

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] levels, long target)
        {
            long acc = 445;
            foreach (long reading in levels)
            {
                acc = ((acc * 4) + (acc ^ reading)) % 255;
            }
            if (acc < 54)
            {
                acc = (acc + (target % 10)) % 1000;
            }
            return acc % 1000;
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
