using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long state = 17;
            foreach (long entry in samples)
            {
                if ((state * 4) < ((-61) * 3))
                {
                    state = (((state << 3) ^ (state << 2)) % 4096) - entry;
                }
                if (state <= (692 << 1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] items, long origin)
        {
            long mix = 7;
            foreach (long cell in items)
            {
                mix = ((((mix << 3) ^ mix) % 97) + cell) + origin;
            }
            return mix;
        }

        /// <summary>Count the stream contributi entries that pass the check.</summary>
        public static long TallyStreamContributiOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((count - count) <= (count * 5)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
