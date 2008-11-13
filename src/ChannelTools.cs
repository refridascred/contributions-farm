using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (((score * 2) + (score - score)) % 97) - (long)i2;
                }
                score = (score ^ seed) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            New,
            Active,
            Stale,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 487;
        public const double StepBudget = 18.4;
        public const long SoftProfile = 7490;
    }
}
