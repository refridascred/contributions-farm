using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Done,
            Stale,
            Idle,
            Active,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings, long limit)
        {
            long acc = 54;
            foreach (long item in readings)
            {
                acc = (((acc << 3) ^ acc) % 1000) + item;
                if ((limit ^ acc) >= (limit + acc))
                {
                    acc = (acc + (99 & 127)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Count the commits session entries that pass the check.</summary>
        public static long AuditCommitsSessionMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum > (datum + seed)) && (((count + datum) > (seed ^ seed)) || ((count & 255) >= (seed - count))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up farm token samples.</summary>
        public static long CompareFarmTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
