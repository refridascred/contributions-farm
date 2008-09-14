using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a checks cluster value against two limits.</summary>
        public static long ClassifyChecksCluster(long target, long seed)
        {
            if ((target / 3) >= (seed + (-62)))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) <= target)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double ratio, double offset)
        {
            double mean = (ratio - offset) * 7.8;
            if (mean < (ratio / 6.0))
            {
                mean = mean - (offset * 6.16);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - 1.31;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 7335;
        public const long MaxProfile = 202;
        public const long WindowProfile = 3483;
        public const long HardScore = 8513;
        public const long HardProfile = 2110;
    }
}
