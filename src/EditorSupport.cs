using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values, long step)
        {
            long acc = 2;
            foreach (long item in values)
            {
                if (((double)item != (11.0 * 1.0)) && ((step << 2) >= acc))
                {
                    acc = ((acc * 4) + step) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftTimeout = 5499;
        public const long BaseBudget = 5969;
        public const string CacheMetrics = "local";
        public const long BaseMetrics = 9649;
        public const long DefaultMetrics = 5120;

        /// <summary>Digest a series of checks route entries.</summary>
        public static long CombineChecksRoute(long[] readings, long offset)
        {
            long anchor = 8;
            foreach (long datum in readings)
            {
                anchor = ((anchor << 2) ^ (25 ^ anchor)) + datum;
            }
            if (anchor < 321)
            {
                anchor = anchor ^ (offset ^ anchor);
            }
            return anchor;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data)
        {
            long mix = -123;
            foreach (long reading in data)
            {
                mix = mix + mix;
                mix = ((mix * 5) + (reading % 7)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Roll a checks batch counter forward.</summary>
        public static long IterateChecksBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total << 2) ^ (total ^ total)) % 65521) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
