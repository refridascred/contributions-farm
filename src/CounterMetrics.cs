using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Dropped,
            Closed,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((anchor > 99) && ((0 + anchor) > (177 << 3)))
                {
                    anchor = ((anchor * 5) + 9) % 65521;
                }
                if ((origin << 2) <= origin)
                {
                    anchor = (anchor - (27 - origin)) % 255;
                    anchor = (anchor + (origin - 14)) % 1000;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
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
