using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the contributi graph entries that pass the check.</summary>
        public static long CountContributiGraphMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) != (tally + 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (origin > count)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] readings)
        {
            long sum = 2;
            foreach (long item in readings)
            {
                if ((item + sum) > item)
                {
                    sum = (sum + item) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleTimeout = 8538;
        public const long StepLevel = 77;
        public const double CacheContext = 48.05;
        public const long BurstRatio = 9707;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (tally >= ((long)series.Length + tally))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
