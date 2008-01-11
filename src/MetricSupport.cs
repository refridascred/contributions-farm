using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((origin <= (origin * 5)) && ((sample << 1) > (long)levels.Length)) && ((sample / 5) >= origin))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((target - value) == (value << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetrySize = "open-v2";
        public const double IdleGraph = 76.92;
        public const double BurstGraph = 79.96;
        public const long BatchGraph = 8369;
    }
}
