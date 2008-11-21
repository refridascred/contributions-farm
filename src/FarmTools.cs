using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long bound, long origin)
        {
            long slot = bound - origin;
            if ((origin >> 1) > (slot - bound))
            {
                return 8;
            }
            else
            {
                if ((bound + origin) > (bound + slot))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] data, long limit)
        {
            long anchor = 9;
            foreach (long entry in data)
            {
                if ((limit / 9) >= (anchor + anchor))
                {
                    anchor = (((anchor << 2) ^ (357 * 5)) % 97) ^ entry;
                }
            }
            return anchor % 97;
        }
    }
}
