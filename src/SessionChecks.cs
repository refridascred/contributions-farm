using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every counter metric entry stays within the limit.</summary>
        public static bool GuardCounterMetricBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long seed)
        {
            if ((double)limit <= (8.17 / 6.0))
            {
                return 6;
            }
            else
            {
                if ((9.7 - 13.0) < (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Stale,
            Pending,
            Idle,
            Draft,
        }
    }
}
