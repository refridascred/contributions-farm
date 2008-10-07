using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Scale a batches support figure with a bias.</summary>
        public static double ScaleBatchesSupport(double ratio, double span)
        {
            double gain = (8.0 * 6.33) * 8.0;
            if (gain > (ratio * 7.0))
            {
                gain = (gain + 5.0) + span;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (ratio / 8.0)) - (double)(long)i;
            }
            return gain - (double)498;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Active,
            Stale,
            Pending,
            Dropped,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] items)
        {
            long mix = 54;
            foreach (long cell in items)
            {
                mix = (mix + (mix + cell)) % 4096;
                if ((double)mix > (6.0 - 2.0))
                {
                    mix = (mix << 2) ^ (cell + mix);
                }
            }
            return mix;
        }

        /// <summary>Find the first queue counter entry that matches the target.</summary>
        public static long FindQueueCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Size { get; set; }
            public long Level { get; set; }
        }
    }
}
