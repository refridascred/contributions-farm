using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 46.14;
        public const double BurstLevel = 76.99;
        public const double IdleRatio = 22.33;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the editor session entries that pass the check.</summary>
        public static long CountEditorSessionOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (matches <= (matches + item))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
