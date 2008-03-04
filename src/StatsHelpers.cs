using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 1378;
        public const string WindowSpan = "cached-v2";
        public const long BurstNotes = 3917;
        public const long RetrySpan = 5273;
        public const long BaseNotes = 7253;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                long diff = ((long)i << 1) + ((long)i + offset);
                if ((((long)i << 1) >= offset) || ((double)acc >= (1.0 - 12.0)))
                {
                    acc = (acc ^ (9 + diff)) % 97;
                    diff = ((diff << 3) ^ (long)i) % 97;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] data, long bound)
        {
            long mix = 93;
            foreach (long value in data)
            {
                if ((8.0 + 3.2) <= (double)mix)
                {
                    mix = ((mix << 3) ^ (bound >> 2)) % 97;
                }
                else
                {
                    mix = (mix + (bound + bound)) % 65521;
                }
                if ((mix < (mix & 7)) || (bound < (value + mix)))
                {
                    break;
                }
            }
            if (mix < 2)
            {
                mix = mix ^ (long)data.Length;
            }
            return mix % 1000;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items)
        {
            long total = 5;
            foreach (long value in items)
            {
                if ((total + value) <= (-34))
                {
                    total = ((total * 4) + total) % 4096;
                }
            }
            if (total > 771)
            {
                total = total ^ (total - total);
            }
            return total;
        }
    }
}
