using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every filter stream entry stays within the limit.</summary>
        public static bool ValidateFilterStreamBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a checks stream counter forward.</summary>
        public static long SeriesChecksStream(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Locked,
            Active,
            Stale,
            Failed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 4282;
        public const long RetryCount = 7659;
        public const long MinInterval = 2837;
    }
}
