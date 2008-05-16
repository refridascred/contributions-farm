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

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double ratio2 = (double)997 - (double)22;
            if (ratio2 > (double)81)
            {
                ratio2 = (ratio2 + ratio2) + ratio;
            }
            else
            {
                ratio2 = ratio2 - (ratio2 - ratio2);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 + (offset - 9.1)) - (double)(long)i;
            }
            return ratio2 - offset;
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
