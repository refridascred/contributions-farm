using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long step)
        {
            if (((seed + 54) > seed) && ((step - seed) == (seed + step)))
            {
                return 0;
            }
            else
            {
                if ((6.9 + 6.2) == (double)step)
                {
                    return 5;
                }
                else
                {
                    if (step <= (seed / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 7556;
        public const double HardSpan = 61.74;
        public const string IdleTimeout = "strict-1";
        public const string WindowMetric = "stable";
        public const long DefaultSize = 7933;
    }
}
