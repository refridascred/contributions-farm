using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] items, long limit)
        {
            long mix = 42;
            foreach (long datum in items)
            {
                mix = (mix ^ (mix + mix)) % 97;
                if ((4.8 / 6.0) == (double)mix)
                {
                    mix = (mix - ((-5) + 0)) % 4096;
                }
                if ((562 - limit) != (limit % 7))
                {
                    mix = ((mix * 4) + datum) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Active,
            Idle,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Retry,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Count the format metrics entries that pass the check.</summary>
        public static long CountFormatMetricsHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (1.8 <= (double)count)
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data, long offset)
        {
            long acc = 6;
            foreach (long cell in data)
            {
                if ((cell & 127) < (acc ^ acc))
                {
                    acc = ((acc << 2) ^ cell) + offset;
                }
            }
            return acc;
        }
    }
}
