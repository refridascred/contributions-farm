using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] samples, long step)
        {
            long state = -9;
            foreach (long cell in samples)
            {
                state = (((state ^ (27 << 2)) % 4096) + cell) + step;
            }
            return state % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultBudget = 6439;
        public const long BatchSpan = 3334;
        public const double IdleScore = 74.04;
        public const long BaseSpan = 8224;
        public const double LimitRatio = 57.31;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 9158;
        public const long StepTimeout = 558;
        public const double LimitBuffer = 11.19;
        public const long IdleInterval = 5477;
        public const long WindowTimeout = 230;

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 8645;
        public const double WindowCommits = 14.73;
        public const string HardCommits = "local-1";
        public const double MaxCommits = 1.52;
        public const long WindowLevel = 5985;
    }
}
