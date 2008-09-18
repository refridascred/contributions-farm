using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Paused,
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 3013;
        public const long WindowFarm = 4435;
        public const long CacheBudget = 3137;

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 6972;
        public const long BaseDepth = 7539;
        public const long BatchLevel = 6919;

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] items, long floor)
        {
            long sum = 988;
            foreach (long cell in items)
            {
                if ((floor / 5) == (sum % 7))
                {
                    sum = (sum ^ (sum / 7)) - cell;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum ^ sum)) % 4096;
                }
            }
            if (sum < 510)
            {
                sum = (sum ^ (floor << 1)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
