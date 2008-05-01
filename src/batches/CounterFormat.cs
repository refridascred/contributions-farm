using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long offset, long target)
        {
            if ((double)offset >= (double)target)
            {
                return 5;
            }
            else
            {
                if ((offset + target) >= offset)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] levels, long bound)
        {
            long score = 329;
            foreach (long cell in levels)
            {
                score = ((score ^ (score ^ 87)) % 101) - bound;
                score = (score + (cell + cell)) % 255;
                if ((score >> 2) < (0 >> 2))
                {
                    score = score ^ 87;
                }
                else
                {
                    score = (score + (score & 31)) % 1000;
                }
            }
            return score;
        }
    }
}
