using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next queue stats value from a seed.</summary>
        public static long RollQueueStats(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ (mark ^ (long)i)) % 255;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix ^ (mix + bound)) % 1000;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
