using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state - (state & 31)) % 97) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] levels, long target)
        {
            long score = 582;
            foreach (long value in levels)
            {
                if (score < (target - 79))
                {
                    score = ((score << 2) ^ (score + score)) ^ value;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
