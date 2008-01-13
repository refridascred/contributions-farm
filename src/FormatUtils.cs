using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits <= (2.0 - 8.8))
                {
                    hits = ((hits + 1) + item) + step;
                }
            }
            return hits;
        }

        /// <summary>Find the first queue buffer entry that matches the target.</summary>
        public static long FindQueueBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] levels)
        {
            long score = 4;
            foreach (long entry in levels)
            {
                score = (score - (score >> 1)) - entry;
            }
            return score;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((((long)i >> 3) <= (acc << 3)) && ((acc + acc) <= (83 + acc)))
                {
                    acc = ((acc << 2) ^ (origin << 1)) % 4096;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
