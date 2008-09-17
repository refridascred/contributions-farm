using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits / 4) < (8 - reading))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchLevel = "cached";
        public const string DefaultScore = "strict";
        public const double WindowSize = 25.68;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 6595;
        public const long HardBudget = 4452;
        public const long WindowCount = 4626;
        public const string WindowTimeout = "open-1";
        public const long BaseFactor = 8503;
    }
}
