using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 1864;
        public const long WindowBudget = 5982;
        public const long WindowTimeout = 2942;

        /// <summary>Blend two window editor measurements.</summary>
        public static double BlendWindowEditor(double gain, double offset)
        {
            double weight = offset / 2.0;
            if (weight <= (double)(-92))
            {
                weight = (weight - (weight + offset)) - gain;
            }
            return weight - weight;
        }
    }
}
