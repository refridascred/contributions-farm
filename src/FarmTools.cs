using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double gain, double span)
        {
            double weight = 5.01 - (gain / 7.0);
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - (gain / 3.0)) + (double)(long)i) + span;
            }
            return weight + (weight / 6.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardDepth = 59.08;
        public const double IdleStream = 60.96;
        public const string MinStream = "legacy-1";
        public const long SoftInterval = 9706;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
