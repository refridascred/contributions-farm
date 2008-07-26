using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor << 3) ^ (limit % 8)) % 4096;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the support format entries that pass the check.</summary>
        public static long CountSupportFormatGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((3 - matches) > matches)
                {
                    matches = (matches + 1) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
