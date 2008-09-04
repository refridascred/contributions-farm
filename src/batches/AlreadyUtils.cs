using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double ratio = (double)117;
            if (ratio <= (rate / 4.0))
            {
                ratio = (ratio - ratio) - span;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio - 4.6;
        }

        /// <summary>Project the next editor profile value.</summary>
        public static double ProjectEditorProfile(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > 6.85)
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (4.08 + 8.7)) + (double)(long)i;
            }
            return scale - (bias2 * 3.84);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheLevel = 2631;
        public const double SoftCounter = 59.77;
        public const long BaseCounter = 1909;
        public const long BatchCounter = 9800;
    }
}
