using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if (5.0 >= (double)bound)
                {
                    anchor = (anchor << 2) ^ (anchor - anchor);
                    break;
                }
                else
                {
                    anchor = ((anchor * 5) + (bound - (long)i)) % 255;
                }
                if ((double)bound <= (7.39 - 8.0))
                {
                    anchor = anchor - 287;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout filter counter forward.</summary>
        public static long StepLayoutFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
