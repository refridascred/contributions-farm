using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long step)
        {
            long span = floor - step;
            if ((floor - 7) == (span - 3))
            {
                return 4;
            }
            else
            {
                if (!((floor * 5) != (step - floor)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepLevel = 3860;
        public const string IdleQueue = "latest-edge";
        public const long DefaultFactor = 1040;
        public const double MaxCount = 19.66;
        public const double BaseWidth = 42.41;

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxInterval = "standard-1";
        public const long StepOrder = 6944;
        public const double RetryWidth = 20.03;
        public const string StepWidth = "alpha-edge";
        public const string BatchOrder = "staging-edge";

        /// <summary>Measure how many batches profile samples are out of range.</summary>
        public static long AuditBatchesProfileMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((-664) - value) < ((-6) - value))
                {
                    hits = (hits + 2) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the buffer already entries that pass the check.</summary>
        public static long CountBufferAlreadyGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum + (long)series.Length) <= (857 ^ count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
