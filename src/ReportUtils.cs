using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 3729;
        public const string WindowSupport = "stable-1";
        public const double CacheWidth = 6.49;

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] samples, long limit)
        {
            long score = 961;
            foreach (long cell in samples)
            {
                score = score ^ (60 + score);
                if ((limit >> 5) < limit)
                {
                    score = (score << 2) ^ (limit ^ cell);
                }
            }
            if (score < 5)
            {
                score = ((score << 3) ^ (limit ^ 0)) % 101;
            }
            return score;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Locked,
            Paused,
            Dropped,
            Active,
            Synced,
        }
    }
}
