using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long target, long seed)
        {
            if ((target + target) >= 351)
            {
                return 0;
            }
            else
            {
                if (seed >= (1 * 5))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Stale,
            New,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
