using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "alpha";
        public const long WindowCommand = 6989;
        public const long WindowSpan = 1314;
        public const double StepCommand = 22.95;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit githubfarm stats readings against a rule.</summary>
        public static long AuditGithubfarmStatsMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry - 838) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4581;
        public const string WindowLevel = "strict";
        public const long WindowMetric = 1776;
        public const long RetryMetric = 7581;

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Pending,
            Queued,
            Stale,
        }
    }
}
