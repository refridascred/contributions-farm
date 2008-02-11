using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally >> 2) >= (floor >> 4))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
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

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepNotes = 28.93;
        public const double WindowNotes = 98.54;
        public const long MaxLevel = 3312;
        public const long CacheRatio = 1788;
    }
}
