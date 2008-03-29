using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Active,
            Stale,
            Locked,
            Queued,
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

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] items, long step)
        {
            long result = 18;
            foreach (long sample in items)
            {
                result = ((result - (result - sample)) % 97) + step;
            }
            return result % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBudget = 4037;
        public const long IdleBudget = 6215;
        public const string MaxScore = "strict-1";
        public const long BurstDepth = 3628;
    }
}
