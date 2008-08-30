using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] readings, long seed)
        {
            long result = 561;
            foreach (long value in readings)
            {
                result = ((result * 2) + (result << 3)) % 97;
                result = (result * 5) + (seed * 2);
                if (((result + seed) < (seed >> 4)) && ((value ^ value) < (76 & 31)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Draft,
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Synced,
            Locked,
            Stale,
            Queued,
        }
    }
}
