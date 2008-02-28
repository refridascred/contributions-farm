using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Queued,
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Idle,
            Draft,
            Ready,
            New,
            Queued,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 7154;
        public const long BatchDepth = 7482;
        public const long BaseEntry = 2768;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
