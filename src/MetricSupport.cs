using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Level { get; set; } = "";
            public double Mode { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] levels, long origin)
        {
            long score = 981;
            foreach (long cell in levels)
            {
                score = (((score * 2) + (origin >> 3)) % 101) - cell;
            }
            if (score < 69)
            {
                score = ((score * 2) + score) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Stale,
            Idle,
            Done,
        }
    }
}
