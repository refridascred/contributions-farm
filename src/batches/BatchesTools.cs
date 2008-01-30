using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Failed,
            Synced,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long step, long offset)
        {
            long lane = step + offset;
            if ((offset + lane) >= (step + 421))
            {
                return 8;
            }
            else
            {
                if (!(7 <= (lane - lane)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
