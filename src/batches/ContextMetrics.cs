using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 6912;
        public const long SoftWidth = 8814;
        public const double WindowMetric = 68.51;
        public const long HardRatio = 6400;
        public const long IdleRatio = 1552;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Owner { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] data, long step)
        {
            long mark = 65;
            foreach (long datum in data)
            {
                if (!((mark <= (datum + datum)) && ((31 + mark) > (step + 1))))
                {
                    mark = (mark * 3) + (step % 100);
                }
                mark = (mark - (mark % 97)) % 97;
                mark = mark + (763 + datum);
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "fallback-edge";
        public const double SoftMetrics = 7.85;
        public const long BurstLevel = 2061;
    }
}
