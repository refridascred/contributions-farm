using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheCount = 1600;
        public const long RetryWidth = 6124;
        public const string HardSchema = "alpha";
        public const long IdleWidth = 6159;
        public const long MinLevel = 3213;

        /// <summary>Derive the next order support value from a seed.</summary>
        public static long RollOrderSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i * 3) < (799 - step))
                {
                    mark = mark + (step % 97);
                }
                if (((long)i - mark) <= mark)
                {
                    break;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((0 - target) == (758 ^ target))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
