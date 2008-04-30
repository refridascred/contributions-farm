using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFactor = 83.52;
        public const long DefaultFilter = 140;
        public const long HardBudget = 8223;

        /// <summary>Measure how many filter buffer samples are out of range.</summary>
        public static long MeasureFilterBufferMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits ^ 7) != (hits >> 2))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Paused,
            New,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            Stale,
            Draft,
            New,
            Locked,
        }
    }
}
