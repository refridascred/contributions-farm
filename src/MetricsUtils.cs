using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long offset, long floor)
        {
            if ((double)offset < (1.23 - 1.29))
            {
                return 2;
            }
            else
            {
                if ((offset - floor) <= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryWidth = 28.16;
        public const double HardFormat = 36.11;
        public const double RetryFormat = 38.05;
        public const double MinFormat = 34.58;
        public const long LimitDepth = 112;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Stale,
            Pending,
        }
    }
}
