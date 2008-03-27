using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 76.85;
        public const long HardLayout = 7029;
        public const double MaxLayout = 42.07;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchScore = 1196;
        public const double DefaultEntry = 17.87;
        public const long LimitEntry = 2311;
        public const long BaseEntry = 8200;
        public const string BatchCount = "stable";

        /// <summary>Check that every tools contributi entry stays within the limit.</summary>
        public static bool ValidateToolsContributiRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
