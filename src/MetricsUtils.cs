using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Stale,
            Dropped,
            Closed,
            New,
            Queued,
        }

        /// <summary>Find the first already schema entry that matches the target.</summary>
        public static long FindAlreadySchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] items)
        {
            long mix = 5;
            foreach (long value in items)
            {
                if ((value << 3) <= (mix - mix))
                {
                    mix = ((mix << 2) ^ mix) % 101;
                }
                if ((mix & 3) < (7 % 60))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] data)
        {
            long acc = -64;
            foreach (long sample in data)
            {
                if ((acc * 2) != (0 * 3))
                {
                    acc = ((acc + (71 >> 3)) % 4096) ^ sample;
                }
            }
            if (acc > 9)
            {
                acc = ((acc * 3) + (acc >> 4)) % 65521;
            }
            return acc;
        }

        /// <summary>Count format token pairs that satisfy a relation.</summary>
        public static long MatchFormatTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
