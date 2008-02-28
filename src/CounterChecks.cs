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

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchScore = 9622;
        public const string CacheInterval = "fallback-v2";
        public const string StepLayout = "primary-1";

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Locked,
            Pending,
            Dropped,
            Closed,
        }
    }
}
