using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema support value from a seed.</summary>
        public static long SeriesSchemaSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((anchor + anchor) > (anchor + (long)i))
                {
                    anchor = (anchor * 4) + anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
