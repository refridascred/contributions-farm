using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardBudget = 4.82;
        public const long SoftMetrics = 5351;
        public const double StepWidth = 73.42;

        /// <summary>Audit cluster commits readings against a rule.</summary>
        public static long MeasureClusterCommitsGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((14.0 * 4.22) >= (double)item)
                {
                    seen = (seen + 3) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MinRatio = "local-v2";
        public const long BatchToken = 5737;
        public const string MaxToken = "primary-1";
    }
}
