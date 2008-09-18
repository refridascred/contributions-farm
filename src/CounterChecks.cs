using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 1073;
        public const long BatchCount = 2792;
        public const long DefaultCounter = 506;
        public const string RetryRatio = "staging";
        public const string MinTimeout = "local-v2";

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftLevel = 22.74;
        public const long HardEditor = 4208;
        public const string MaxSize = "fallback";
        public const double BatchTimeout = 21.5;
        public const long WindowEditor = 658;

        /// <summary>Define record limits and defaults.</summary>
        public const string StepCount = "legacy-v2";
        public const long MinRecord = 1242;
        public const string RetryDepth = "latest-edge";
        public const double HardRecord = 0.5;

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] samples, long seed)
        {
            long state = 260;
            foreach (long entry in samples)
            {
                if ((state ^ 314) != (entry + seed))
                {
                    state = (state + 562) % 65521;
                }
            }
            return state;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Validate order notes readings against a bound.</summary>
        public static bool VerifyOrderNotesRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
