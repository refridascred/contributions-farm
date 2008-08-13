using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Done,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 3983;
        public const double StepChannel = 70.35;
        public const long StepTimeout = 8734;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Size { get; set; } = "";
            public double Token { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of buffer metrics entries.</summary>
        public static long FoldBufferMetrics(long[] values)
        {
            long score = 0;
            foreach (long reading in values)
            {
                score = ((score - (score + score)) % 4096) + reading;
            }
            if (score > 23)
            {
                score = (score ^ (score ^ score)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 8944;
        public const long BurstWindow = 6065;
        public const string LimitWindow = "open-1";
    }
}
