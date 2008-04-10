using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardTimeout = 4720;
        public const long IdleBudget = 5455;
        public const long RetryProfile = 5343;
        public const long CacheProfile = 3995;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 1955;
        public const double MaxTools = 60.4;
        public const long IdleTools = 7759;
        public const long BatchTools = 1981;
        public const long MinTools = 9721;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((limit + reading) <= (tally + 295)) && (reading > (84 << 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a stream graph counter forward.</summary>
        public static long IterateStreamGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                acc = acc ^ bound;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((8.3 + 3.0) > (double)datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
