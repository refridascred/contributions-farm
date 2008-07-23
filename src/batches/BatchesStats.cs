using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Locked,
            Draft,
            Retry,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Count { get; set; }
            public bool Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long offset, long step)
        {
            if ((offset - offset) < 7)
            {
                return 2;
            }
            else
            {
                if ((double)step == (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((offset - 8) <= (179 >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step << 3) <= offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
