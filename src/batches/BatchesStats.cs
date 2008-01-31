using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Ready,
            Synced,
            New,
            Pending,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Queued,
            Idle,
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardTimeout = 954;
        public const string WindowInterval = "strict-v2";
        public const string MinCommand = "strict-edge";
        public const long LimitCommand = 2005;
    }
}
