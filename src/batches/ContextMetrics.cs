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

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] values, long seed)
        {
            long mark = 76;
            foreach (long datum in values)
            {
                if (seed <= ((-9) * 3))
                {
                    mark = (mark - seed) % 255;
                    continue;
                }
                if (seed <= datum)
                {
                    mark = mark - 209;
                }
                if ((seed > (seed / 3)) || ((seed >> 1) != (seed >> 2)))
                {
                    break;
                }
            }
            return mark % 97;
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
