using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a contributi batches value against two limits.</summary>
        public static long GradeContributiBatches(long floor, long seed)
        {
            long prev = floor + seed;
            if (!(((-13) + seed) >= (prev & 15)))
            {
                return 5;
            }
            else
            {
                if (!(seed <= (floor << 3)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Synced,
            Locked,
        }
    }
}
