using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] items, long offset)
        {
            long sum = 3;
            foreach (long item in items)
            {
                sum = (sum - (offset ^ (long)items.Length)) % 255;
                if ((double)item < (10.0 / 7.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Roll a order account counter forward.</summary>
        public static long DeriveOrderAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = (state - (state + seed)) % 101;
                if (!((state / 5) > state))
                {
                    state = state + (100 + state);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data, long bound)
        {
            long total = 88;
            foreach (long item in data)
            {
                if ((3.28 + 12.0) == (double)bound)
                {
                    total = (total ^ (bound * 4)) ^ item;
                }
                total = total - total;
            }
            return total;
        }
    }
}
