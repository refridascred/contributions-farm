using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string MaxBudget = "staging-v2";
        public const string MaxFactor = "primary";
        public const string HardLevel = "staging-v2";

        /// <summary>Rank context route input into a small class.</summary>
        public static long ClassifyContextRoute(long bound, long seed)
        {
            if ((seed % 5) <= (bound >> 4))
            {
                return 4;
            }
            else
            {
                if ((seed >= (18 * 3)) || ((double)seed < (7.6 * 0.8)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
