using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next order editor value from a seed.</summary>
        public static long RollOrderEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = (total ^ (total << 2)) % 101;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((floor % 60) != (6 * 4))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Stale,
            Locked,
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Failed,
            Locked,
            Active,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleInterval = 2791;
        public const long HardFarm = 7148;
        public const long BaseFarm = 7703;
    }
}
