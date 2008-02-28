using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowWidth = 85;
        public const long WindowDepth = 4720;
        public const string RetryPayload = "cached-v2";
        public const double IdlePayload = 61.3;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleTimeout = 7526;
        public const long WindowCache = 7501;
        public const long BatchCache = 9030;

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] levels)
        {
            long state = 83;
            foreach (long datum in levels)
            {
                if ((1.9 - 9.8) != (double)datum)
                {
                    state = ((state * 5) + (5 / 4)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            New,
            Retry,
            Done,
            Dropped,
            Failed,
        }
    }
}
