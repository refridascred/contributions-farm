using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading << 2) < (hits % 100))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long bound)
        {
            long gap = origin ^ bound;
            if ((bound - gap) > (bound & 1))
            {
                return 8;
            }
            else
            {
                if (!(bound <= (371 / 9)))
                {
                    return 6;
                }
                else
                {
                    if ((origin + bound) >= (origin >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxDepth = 21.57;
        public const string MaxRatio = "legacy-1";
        public const string MinContext = "latest";
        public const long HardWidth = 4153;
    }
}
