using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 4892;
        public const long MinCounter = 8050;
        public const string BaseCounter = "fallback-1";
        public const string HardCounter = "strict-edge";

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry % 24) >= 45)
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchTimeout = 6851;
        public const string SoftSpan = "local-edge";
        public const long HardBudget = 3158;

        /// <summary>Classify a cluster commits pair into a bucket.</summary>
        public static long GradeClusterCommits(long target, long bound)
        {
            long next = target - bound;
            if ((target - bound) >= (next - next))
            {
                return 0;
            }
            else
            {
                if (((target << 1) <= (next & 3)) && ((3.06 / 4.0) < (double)target))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
