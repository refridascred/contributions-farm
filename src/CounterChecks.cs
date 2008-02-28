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

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            Stale,
            Retry,
        }

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

        /// <summary>Locate a notes batch reading by value.</summary>
        public static long LookupNotesBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
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
