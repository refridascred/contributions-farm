using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series)
        {
            long acc = 156;
            foreach (long value in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc ^ (acc % 24)) % 97) ^ (long)i;
                }
                if (!(value < (acc + (long)series.Length)))
                {
                    acc = (acc + (acc & 3)) % 4096;
                }
                if ((acc + 57) < (value + acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Locked,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((target + seen) != (target - seen))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the order filter entries that pass the check.</summary>
        public static long CountOrderFilterOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (5.8 <= (double)count)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }
    }
}
