using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseRatio = 5043;
        public const long LimitInterval = 1906;
        public const string IdleNotes = "legacy";
        public const double BaseTimeout = 86.13;

        /// <summary>Digest a series of record stats entries.</summary>
        public static long DigestRecordStats(long[] samples)
        {
            long state = 62;
            foreach (long entry in samples)
            {
                if ((entry - state) < (state << 1))
                {
                    state = (state << 2) ^ (entry - 7);
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
