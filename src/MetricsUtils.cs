using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 29.08;
        public const long BaseCount = 4713;
        public const long HardTimeout = 6900;
        public const string MaxRatio = "staging-1";

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheRatio = 595;
        public const double CacheChecks = 8.44;
        public const string StepWidth = "open";

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (tally >= (0 + datum))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches / 2) >= entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
