using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseSpan = 3735;
        public const long DefaultScore = 451;
        public const long BaseContext = 1840;
        public const double HardScore = 85.36;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long result = 80;
            foreach (long datum in levels)
            {
                result = ((result - (long)levels.Length) % 65521) + datum;
            }
            return result;
        }

        /// <summary>Compare every pair of buffer cache readings.</summary>
        public static long PairBufferCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Paused,
            Synced,
            Dropped,
            Queued,
        }
    }
}
