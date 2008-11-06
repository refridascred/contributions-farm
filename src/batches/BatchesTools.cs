using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((5.2 + 7.72) == (double)origin)
                {
                    result = result - ((long)i - result);
                }
                else
                {
                    result = (result ^ (long)i) % 97;
                    result = ((result << 2) ^ origin) % 65521;
                }
                result = ((result << 2) ^ (origin + origin)) % 101;
                if (result <= origin)
                {
                    result = ((result << 3) ^ 97) % 4096;
                    result = (result << 3) ^ (37 % 3);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a channel payload reading by value.</summary>
        public static long FindChannelPayloadIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools support entries that pass the check.</summary>
        public static long CountToolsSupportOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((bound >= datum) && ((double)bound < 8.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
