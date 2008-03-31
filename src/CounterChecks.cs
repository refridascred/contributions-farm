using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!((0 + matches) > reading))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 21.8;
        public const long CacheSpan = 6039;
        public const long SoftToken = 6041;
        public const long WindowInterval = 7222;
        public const long RetrySize = 9871;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Done,
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)matches >= 0.1)
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading * 3) < (count ^ reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepDepth = 9021;
        public const string LimitBudget = "latest-1";
        public const string HardSpan = "primary-v2";
    }
}
