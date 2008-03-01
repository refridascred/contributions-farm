using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)origin != (7.23 / 2.0)))
                {
                    sum = ((sum * 5) + origin) % 97;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] series, long floor)
        {
            long mix = 61;
            foreach (long item in series)
            {
                mix = mix ^ floor;
                if (((mix % 24) >= (floor % 7)) && (641 > (item + item)))
                {
                    mix = ((mix * 5) + (item >> 5)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Locked,
            Pending,
            Synced,
            Closed,
        }
    }
}
