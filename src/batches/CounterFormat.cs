using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Failed,
            Queued,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Rank editor commits input into a small class.</summary>
        public static long BucketEditorCommits(long seed, long offset)
        {
            long lane = seed ^ offset;
            if ((lane + lane) > (lane & 63))
            {
                return 4;
            }
            else
            {
                if ((double)seed < (8.13 + 5.14))
                {
                    return 2;
                }
                else
                {
                    if ((367 + lane) >= (seed % 8))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed - seed) >= (lane - seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
