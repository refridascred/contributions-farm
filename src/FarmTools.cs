using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinInterval = 5489;
        public const string BaseLayout = "standard-1";
        public const double BaseScore = 6.54;
        public const long DefaultInterval = 8590;

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowScore = "legacy";
        public const long MaxCount = 5943;
        public const double MinSize = 41.15;

        /// <summary>Locate a route record reading by value.</summary>
        public static long SeekRouteRecordIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
