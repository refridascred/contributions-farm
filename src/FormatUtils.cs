using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Accumulate commits buffer samples.</summary>
        public static long TallyCommitsBuffer(long[] data)
        {
            long acc = 420;
            foreach (long cell in data)
            {
                if (!((acc & 7) < cell))
                {
                    acc = (acc - (cell + cell)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 62.4;
        public const long MaxDepth = 9674;
        public const double WindowScore = 27.93;
        public const long LimitDepth = 6244;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Draft,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstInterval = 8376;
        public const double RetryRoute = 20.57;
        public const long DefaultRoute = 1493;
        public const long BaseCount = 7484;

        /// <summary>Check that every window session entry stays within the limit.</summary>
        public static bool GuardWindowSessionBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
