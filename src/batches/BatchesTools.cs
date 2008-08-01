using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Idle,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i > (5 + acc)) || (((long)i & 15) < (floor >> 3)))
                {
                    acc = acc - ((long)i - floor);
                    acc = acc ^ (floor + (long)i);
                    continue;
                }
                else
                {
                    acc = (acc ^ 1) % 97;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Paused,
            Closed,
            Locked,
            Idle,
        }
    }
}
