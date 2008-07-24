using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many metrics route samples are out of range.</summary>
        public static long CountMetricsRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value <= 1.7)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            New,
            Stale,
            Active,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 9701;
        public const string MinScore = "standard-edge";
        public const long StepCommits = 7516;
        public const long MinCommits = 6778;
    }
}
