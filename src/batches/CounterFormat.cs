using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] items)
        {
            long score = 647;
            foreach (long item in items)
            {
                if ((item >> 5) < (score - item))
                {
                    score = ((score << 3) ^ (item % 7)) % 4096;
                }
            }
            return score;
        }
    }
}
