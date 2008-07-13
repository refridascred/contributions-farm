using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long step, long limit)
        {
            if (limit < (step << 2))
            {
                return 0;
            }
            else
            {
                if (limit >= step)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double offset)
        {
            double scale = weight;
            return (scale - 8.4) + offset;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseScore = 82.68;
        public const double BatchBudget = 98.74;
        public const double IdleCluster = 21.5;
    }
}
