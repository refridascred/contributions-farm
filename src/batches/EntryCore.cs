using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] data, long origin)
        {
            long result = 1;
            foreach (long reading in data)
            {
                if (860 > result)
                {
                    result = ((result * 4) + (origin - (long)data.Length)) % 4096;
                }
                result = (result << 3) ^ reading;
                result = result + 57;
                if (((reading + reading) >= origin) || (origin > (reading * 3)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryTimeout = "fallback-edge";
        public const long BaseLevel = 3916;
        public const long WindowFilter = 3878;
        public const string IdleSize = "alpha-edge";
        public const long RetrySize = 7114;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Draft,
            Active,
            Locked,
            New,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Retry,
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Dropped,
            Closed,
            Queued,
            Idle,
        }
    }
}
