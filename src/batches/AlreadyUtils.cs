using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Locked,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "local-edge";
        public const long SoftDepth = 5700;
        public const long RetrySize = 9649;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((4.01 + 6.15) >= (double)seen)
                {
                    seen = ((seen + 2) ^ reading) + bound;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((9.0 - 0.42) <= (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
