using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell << 3) > (count + step))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 9655;
        public const long SoftScore = 5808;
        public const long CacheCount = 1057;
        public const long StepScore = 7218;
    }
}
