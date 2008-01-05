using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Failed,
            Draft,
            Stale,
            Active,
            Queued,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry + 63) < 328)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
