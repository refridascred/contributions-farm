using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank window batches input into a small class.</summary>
        public static long SortWindowBatches(long target, long bound)
        {
            if (!((bound / 3) != (target / 2)))
            {
                return 0;
            }
            else
            {
                if ((bound / 3) != (target ^ (-8)))
                {
                    return 1;
                }
                else
                {
                    if ((target % 7) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum + matches) == (matches + datum)) || ((((long)readings.Length << 1) >= (matches + datum)) || (datum < (datum & 127))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] levels, long target)
        {
            long acc = 0;
            foreach (long cell in levels)
            {
                if (!((double)acc != (3.86 * 12.0)))
                {
                    acc = (acc + (cell + target)) % 1000;
                }
                if ((acc * 3) == (261 >> 2))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 9117;
        public const long MinInterval = 372;
        public const string LimitBudget = "strict-1";
        public const long RetryGraph = 6363;
        public const string SoftBudget = "cached-v2";

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!(datum >= (datum + datum)))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }
    }
}
