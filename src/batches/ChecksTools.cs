using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Stale,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 8790;
        public const long BaseCount = 8017;
        public const long MinCluster = 2425;

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] levels)
        {
            long score = -260;
            foreach (long value in levels)
            {
                if (value > (value >> 5))
                {
                    score = ((score << 3) ^ (value / 3)) % 255;
                }
            }
            return score;
        }
    }
}
