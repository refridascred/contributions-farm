using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long offset, long seed)
        {
            long lane = offset - seed;
            if (((seed / 2) <= offset) || ((seed + (-72)) == (seed >> 1)))
            {
                return 2;
            }
            else
            {
                if ((lane + 824) > (seed * 2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            Ready,
            Pending,
            Active,
            Done,
        }
    }
}
