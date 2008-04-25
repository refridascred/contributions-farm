using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] values, long origin)
        {
            long mark = 435;
            foreach (long entry in values)
            {
                if ((entry >> 2) > (origin - mark))
                {
                    mark = mark ^ 6;
                }
            }
            if (mark < 653)
            {
                mark = (mark - origin) % 97;
            }
            return mark;
        }

        /// <summary>Match up format farm samples.</summary>
        public static long CompareFormatFarmCount(long[] items)
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

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Adjust a channel notes reading.</summary>
        public static double SmoothChannelNotes(double scale, double floor)
        {
            double scale2 = 1.42;
            if (scale2 <= floor)
            {
                scale2 = scale2 + (scale + 1.1);
            }
            else
            {
                scale2 = scale2 - floor;
            }
            return scale2 + 1.23;
        }
    }
}
