using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate profile queue readings against a bound.</summary>
        public static bool ValidateProfileQueueLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Draft,
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Grade a schema batch value against two limits.</summary>
        public static long SortSchemaBatch(long step, long limit)
        {
            if ((13.0 + 10.0) <= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((step + 60) != (step / 2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 5628;
        public const double HardFormat = 45.58;
        public const long RetryScore = 1824;
        public const long StepFormat = 3853;
        public const long LimitFormat = 6509;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Paused,
            Failed,
        }
    }
}
