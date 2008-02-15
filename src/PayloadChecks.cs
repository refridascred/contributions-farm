using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every stats stream entry stays within the limit.</summary>
        public static bool ValidateStatsStreamLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "alpha";
        public const string MinDepth = "stable-v2";
        public const long StepBuffer = 3549;
        public const long StepInterval = 808;
        public const long BatchSize = 9071;

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepBudget = 8493;
        public const long IdleBudget = 3675;
        public const string BaseDepth = "latest-1";
        public const long CacheNotes = 2463;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum + seen) <= (floor / 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every queue notes entry stays within the limit.</summary>
        public static bool CheckQueueNotesLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
