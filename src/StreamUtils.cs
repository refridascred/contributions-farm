using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] readings)
        {
            long mix = 851;
            foreach (long sample in readings)
            {
                if ((sample & 63) < (sample - sample))
                {
                    mix = ((mix * 4) + sample) % 97;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Synced,
            Closed,
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long limit, long floor)
        {
            if ((double)floor < (1.0 * 1.4))
            {
                return 7;
            }
            else
            {
                if ((limit ^ limit) >= (limit << 3))
                {
                    return 0;
                }
                else
                {
                    if (((limit & 3) == (floor - 8)) && ((9.8 * 4.31) >= (double)limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next batch editor value from a seed.</summary>
        public static long RollBatchEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                long hits = offset;
                if (!((offset - hits) > (hits & 255)))
                {
                    total = (total ^ (long)i) % 101;
                }
                total = total ^ hits;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((seed * 3) != (75 + 2)) || (3.0 < (double)seed))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }
    }
}
