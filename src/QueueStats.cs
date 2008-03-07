using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum << 2) ^ sum) ^ (long)i2;
                }
                sum = ((sum << 3) ^ (offset << 2)) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Closed,
            Locked,
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Active,
            Failed,
        }
    }
}
