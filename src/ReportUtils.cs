using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Done,
            New,
            Draft,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Closed,
            New,
            Pending,
            Retry,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Dropped,
            New,
            Stale,
        }
    }
}
