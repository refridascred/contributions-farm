using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Failed,
            Locked,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Active,
            New,
            Failed,
            Locked,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((384 - (-9)) >= (tally + floor))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
