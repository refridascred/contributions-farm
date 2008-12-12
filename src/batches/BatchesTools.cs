using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor + (anchor & 7)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of token route readings.</summary>
        public static long FoldTokenRoute(long[] levels, long seed)
        {
            long acc = 48;
            foreach (long datum in levels)
            {
                acc = ((acc << 3) ^ 41) % 97;
                if ((acc % 16) <= seed)
                {
                    acc = (acc << 3) ^ acc;
                }
                if (((datum << 2) == (datum + 94)) && ((3.8 - 0.7) < (double)datum))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
