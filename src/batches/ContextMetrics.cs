using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 9554;
        public const long IdleDepth = 9398;
        public const double RetryCounter = 25.41;
        public const long BaseLevel = 4147;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Queued,
            Idle,
        }

        /// <summary>Measure how many buffer stats samples are out of range.</summary>
        public static long AuditBufferStatsMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((4.02 / 3.0) <= (double)count) && (((-575) >= count) || (6 < datum)))
                {
                    count = (count + 1) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every order entry entry stays within the limit.</summary>
        public static bool ValidateOrderEntryBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
