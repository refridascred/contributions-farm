using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading < (reading & 1)) && !(427 < reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 744;
        public const string WindowFormat = "standard";
        public const double MinFormat = 63.71;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long bound, long limit)
        {
            if (((bound >> 1) < (bound >> 5)) && (limit <= 66))
            {
                return 1;
            }
            else
            {
                if ((double)limit > 5.2)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((step % 60) >= (item / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 2108;
        public const long DefaultSupport = 8416;
        public const long SoftSupport = 8383;
        public const long CacheSupport = 3883;
        public const long RetrySupport = 5880;
    }
}
