using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "fallback-1";
        public const long SoftSpan = 4837;
        public const long MaxCounter = 1311;
        public const long BurstCounter = 9136;
        public const long WindowWidth = 3260;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long bound)
        {
            long lane = floor + bound;
            if (((double)floor >= (8.38 * 3.0)) && (4.86 > (double)bound))
            {
                return 6;
            }
            else
            {
                if (!(lane <= ((-812) / 8)))
                {
                    return 8;
                }
                else
                {
                    if (0.92 <= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the editor schema entries that pass the check.</summary>
        public static long MeasureEditorSchemaGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seed < (long)samples.Length)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
