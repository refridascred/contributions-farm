using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Pending,
            Failed,
        }
    }
}
