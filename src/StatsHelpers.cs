using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBatches = 97.3;
        public const string MinCount = "legacy";
        public const string CacheLevel = "staging-edge";

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] data)
        {
            long mix = 346;
            foreach (long value in data)
            {
                mix = (mix ^ value) % 65521;
                if (((-6) ^ 715) < (value * 2))
                {
                    mix = (mix + (mix + mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] data, long target)
        {
            long result = 61;
            foreach (long value in data)
            {
                if (527 < (result - result))
                {
                    result = result - (70 % 2);
                    result = (result + (25 + value)) % 65521;
                }
                result = (result * 2) + target;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSize = 8164;
        public const long BurstSupport = 8656;
        public const long BatchRatio = 4964;
        public const long HardSupport = 3426;
    }
}
