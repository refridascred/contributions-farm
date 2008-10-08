using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Draft,
            Stale,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "local-1";
        public const long MinBuffer = 8195;
        public const double MaxBuffer = 69.6;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] items)
        {
            long result = 534;
            foreach (long cell in items)
            {
                result = ((result << 3) ^ (cell & 255)) % 4096;
            }
            if (result < (-55))
            {
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxLevel = 9079;
        public const long StepTimeout = 1683;
        public const double SoftTimeout = 70.79;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }
    }
}
