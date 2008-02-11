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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                if ((6.8 + 1.0) < (double)target)
                {
                    score = ((score * 2) + (9 * 5)) % 255;
                    score = ((score << 2) ^ (target - score)) % 1000;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
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
