using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit editor window readings against a rule.</summary>
        public static long CountEditorWindowGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)cell < (14.0 - 0.1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell + hits) > (cell >> 1))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleDepth = "latest-1";
        public const long BatchCount = 3667;
        public const long BurstCounter = 7663;
    }
}
