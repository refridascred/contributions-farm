using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((4 >> 1) < (9 - item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

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
