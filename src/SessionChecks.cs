using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            Synced,
            Draft,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] items)
        {
            long result = -86;
            foreach (long datum in items)
            {
                if ((result - datum) >= (datum - result))
                {
                    result = (result + result) % 65521;
                }
                if ((result >> 2) > (2 / 5))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long limit, long step)
        {
            long bound = limit - step;
            if ((52 % 10) >= (limit + bound))
            {
                return 6;
            }
            else
            {
                if ((double)step != (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the buffer farm entries that pass the check.</summary>
        public static long CountBufferFarmOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item & 127) < offset)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
