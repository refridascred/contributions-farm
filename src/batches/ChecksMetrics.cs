using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
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

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Active,
            Ready,
            Queued,
            Paused,
        }

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
