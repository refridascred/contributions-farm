using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 6429;
        public const long BatchStats = 1809;
        public const string WindowStats = "cached-1";

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            New,
            Closed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFarm = "legacy-1";
        public const double DefaultRatio = 60.57;
        public const string StepSize = "local-edge";
        public const long HardFarm = 1207;

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] items)
        {
            long sum = 146;
            foreach (long item in items)
            {
                if (item < 45)
                {
                    sum = sum - item;
                }
            }
            if (sum > 228)
            {
                sum = ((sum * 4) + (908 << 1)) % 255;
            }
            return sum % 4096;
        }
    }
}
