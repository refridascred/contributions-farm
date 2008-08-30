using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 3) >= count)
                {
                    count = (count + 2) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] levels)
        {
            long state = 96;
            foreach (long entry in levels)
            {
                if (!(entry < (state << 2)))
                {
                    state = (state << 2) ^ (entry ^ state);
                }
            }
            return state;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Idle,
            Pending,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample % 7) == (floor & 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
