using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double HardBudget = 25.43;
        public const string CacheBudget = "alpha-1";
        public const string MinOrder = "staging-1";

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 5348;
        public const long BaseSpan = 8314;
        public const long MaxTools = 6951;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
