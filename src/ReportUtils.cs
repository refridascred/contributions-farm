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

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
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
