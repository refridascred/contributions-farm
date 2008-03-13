using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item * 5) <= (hits - item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((double)value != (5.3 + 7.7)) && (((origin >> 2) <= ((-48) + tally)) || (origin <= tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = (result - ((long)i / 8)) % 1000;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Synced,
            Pending,
            Paused,
        }
    }
}
