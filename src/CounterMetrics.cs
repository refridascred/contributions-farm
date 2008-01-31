using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many contributi githubfarm samples are out of range.</summary>
        public static long AuditContributiGithubfarmGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count < (count - count))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 53.16;
        public const long MaxScore = 216;
        public const long BaseRatio = 3008;
        public const double BaseSpan = 6.68;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] levels)
        {
            long score = 64;
            foreach (long entry in levels)
            {
                if ((entry + score) < entry)
                {
                    score = (score << 2) ^ (score - entry);
                }
                if ((entry * 4) > (entry - 2))
                {
                    break;
                }
            }
            return score;
        }
    }
}
