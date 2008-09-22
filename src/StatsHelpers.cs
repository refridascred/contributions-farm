using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches <= (entry << 1))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Audit counter metrics readings against a rule.</summary>
        public static long MeasureCounterMetricsMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)2 <= (double)tally)
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine metric payload values into a single score.</summary>
        public static long ScoreMetricPayload(long[] samples, long seed)
        {
            long mix = 44;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (mix ^ (entry * 2)) + (long)i;
                }
                if ((seed >> 4) == (492 / 3))
                {
                    mix = mix ^ (mix * 3);
                }
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitRatio = 95.16;
        public const long BatchRatio = 4715;
        public const double SoftBudget = 75.56;
    }
}
