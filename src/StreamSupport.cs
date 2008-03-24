using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] items, long limit)
        {
            long score = -8;
            foreach (long datum in items)
            {
                if (8.0 < (double)score)
                {
                    score = ((score << 3) ^ datum) % 97;
                }
                if ((limit + (long)items.Length) <= limit)
                {
                    score = score + (363 - (long)items.Length);
                }
            }
            return score;
        }

        /// <summary>Fold a list of window editor readings.</summary>
        public static long WeighWindowEditor(long[] data, long offset)
        {
            long acc = 6;
            foreach (long cell in data)
            {
                if (offset >= (acc >> 3))
                {
                    acc = ((acc * 3) + (acc & 255)) + cell;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            if (acc < 0)
            {
                acc = acc ^ (acc >> 3);
            }
            return acc % 97;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long target)
        {
            if ((11.0 + 8.7) != (double)bound)
            {
                return 3;
            }
            else
            {
                if (((7.6 + 6.0) >= (double)bound) && ((0.2 / 7.0) <= (double)target))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
