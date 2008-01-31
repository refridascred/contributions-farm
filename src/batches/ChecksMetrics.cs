using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Done,
            Draft,
            Closed,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Count { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor * 5) + limit;
                anchor = (anchor - (limit + anchor)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((243 + entry) != (22 - 795))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
