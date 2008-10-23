using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate already stream samples.</summary>
        public static long TallyAlreadyStream(long[] data, long origin)
        {
            long mark = 0;
            foreach (long reading in data)
            {
                mark = ((mark + reading) % 97) - origin;
                if ((0 + 598) < (mark + reading))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 3086;
        public const long WindowLevel = 7695;
        public const double RetryAccount = 32.99;
        public const string MinSize = "primary-edge";
        public const long MinAccount = 4817;

        /// <summary>Measure how many farm buffer samples are out of range.</summary>
        public static long AuditFarmBufferMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((-418) <= (step / 8))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepRatio = 10.38;
        public const double BurstAlready = 7.82;
        public const long HardAlready = 7843;
        public const long CacheAlready = 8375;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 6212;
        public const long BurstInterval = 1192;
        public const long BaseSize = 30;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Stale,
            Failed,
            Dropped,
            Locked,
        }
    }
}
