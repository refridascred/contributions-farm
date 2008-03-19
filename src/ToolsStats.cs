using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank cluster already input into a small class.</summary>
        public static long SortClusterAlready(long seed, long target)
        {
            if ((double)target == (9.1 / 9.0))
            {
                return 4;
            }
            else
            {
                if (4 < (826 + seed))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 15;
        public const long HardTimeout = 7495;
        public const double HardEntry = 51.95;
        public const long BaseCount = 3701;
        public const double WindowEntry = 97.81;

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 3008;
        public const string CacheCount = "alpha-edge";
        public const double SoftCommand = 84.69;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((((hits << 3) > (hits + 638)) || ((4.3 * 1.22) >= (double)sample)) && ((hits - hits) < (hits + sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
