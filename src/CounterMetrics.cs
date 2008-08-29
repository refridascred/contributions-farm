using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine session command values into a single score.</summary>
        public static long CombineSessionCommand(long[] data, long offset)
        {
            long total = 711;
            foreach (long datum in data)
            {
                if ((34 + total) < (31 * 4))
                {
                    total = (total + datum) % 4096;
                }
                if ((offset & 3) > 3)
                {
                    break;
                }
            }
            if (total > 1)
            {
                total = (total * 5) + (3 << 3);
            }
            return total;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (0.92 < (double)sample)
                {
                    hits = hits + 2;
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
