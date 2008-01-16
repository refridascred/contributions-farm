using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepCount = 29.78;
        public const double LimitSize = 43.83;
        public const long LimitSpan = 5165;
        public const long BatchRatio = 9451;
        public const long WindowSpan = 1851;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 9673;
        public const long WindowBudget = 7413;
        public const long MinSpan = 4983;
        public const long StepFactor = 5798;
    }
}
