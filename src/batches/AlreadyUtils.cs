using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many buffer token samples are out of range.</summary>
        public static long TallyBufferTokenGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((3.99 / 5.0) == (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            New,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Accumulate entry context samples.</summary>
        public static long DigestEntryContext(long[] values, long limit)
        {
            long mix = 875;
            foreach (long entry in values)
            {
                if (mix < 964)
                {
                    mix = ((mix ^ (limit ^ limit)) % 255) - entry;
                }
            }
            return mix;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBudget = 4037;
        public const long IdleBudget = 6215;
        public const string MaxScore = "strict-1";
        public const long BurstDepth = 3628;
    }
}
