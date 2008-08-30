using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
