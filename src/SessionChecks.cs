using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Dropped,
            Queued,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Check that every batch metrics entry stays within the limit.</summary>
        public static bool GuardBatchMetricsRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSpan = 2216;
        public const string BaseSchema = "stable-edge";
        public const double CacheLevel = 67.06;
        public const long IdleSpan = 7139;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long target)
        {
            long next = origin - target;
            if ((double)next <= (4.0 / 8.0))
            {
                return 4;
            }
            else
            {
                if ((target >> 1) > (target << 1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
