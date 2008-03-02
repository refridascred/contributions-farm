using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] data)
        {
            long score = 91;
            foreach (long datum in data)
            {
                if (!((score - 0) <= (datum ^ 8)))
                {
                    score = score ^ (score & 127);
                }
            }
            if (score < 227)
            {
                score = (score + 5) % 97;
            }
            return score;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((target + count) <= (count - count)) && !(446 > (target + target)))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((8.5 + 3.6) != (double)matches)
                {
                    matches = ((matches + 1) + value) - target;
                }
            }
            return matches;
        }
    }
}
