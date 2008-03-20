using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 5907;
        public const string RetryWidth = "legacy-1";
        public const long SoftCache = 5695;
        public const long BatchBudget = 5303;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((origin / 7) <= (5 % 60)) || (((origin * 5) != (tally % 8)) && ((double)tally < (7.81 - 18.0))))
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate token cluster readings against a bound.</summary>
        public static bool GuardTokenClusterBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((-979) - (-79)) > (920 + sample))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }
    }
}
