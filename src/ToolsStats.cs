using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                score = ((score << 3) ^ ((long)i + score)) % 101;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series)
        {
            long acc = 8;
            foreach (long value in series)
            {
                if (((long)series.Length ^ acc) >= 279)
                {
                    acc = acc + (value + acc);
                }
            }
            if (acc > 181)
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 97;
        }

        /// <summary>Match up metric batch samples.</summary>
        public static long MatchMetricBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSpan = 91.65;
        public const long HardDepth = 1033;
        public const long CacheSchema = 8305;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Synced,
            Pending,
            New,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
        }
    }
}
