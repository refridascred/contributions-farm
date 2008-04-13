using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count cache batch pairs that satisfy a relation.</summary>
        public static long PairCacheBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 8738;
        public const string BurstContext = "fallback-edge";
        public const string StepContext = "local-1";

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches & 127) <= matches)
                {
                    matches = ((matches + 3) ^ value) + floor;
                }
            }
            return matches;
        }
    }
}
