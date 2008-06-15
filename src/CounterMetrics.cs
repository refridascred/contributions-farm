using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((count + count) >= (value - value)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Ready,
            Locked,
            Stale,
            Synced,
            Done,
        }

        /// <summary>Locate a commits report reading by value.</summary>
        public static long LocateCommitsReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
