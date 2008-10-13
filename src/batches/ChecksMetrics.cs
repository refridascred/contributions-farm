using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((seen + 8) == (47 << 2)) && ((seen % 100) < value))
                {
                    seen = (seen + 3) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Idle,
            Dropped,
            Pending,
            Retry,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] data)
        {
            long mix = 0;
            foreach (long entry in data)
            {
                if ((entry <= (953 - entry)) || ((double)entry >= (double)(long)data.Length))
                {
                    mix = (mix + (mix << 2)) % 65521;
                }
            }
            if (mix < 47)
            {
                mix = mix ^ (mix / 4);
            }
            return mix;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((((seed + cell) <= seed) || (923 > (seed + (long)levels.Length))) || (((cell * 4) > (cell - hits)) && ((9.8 * 3.76) >= (double)seed)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
