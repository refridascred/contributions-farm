using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long step)
        {
            long gap = bound - step;
            if (!(gap > (step * 3)))
            {
                return 8;
            }
            else
            {
                if ((((-5) % 60) > (75 ^ bound)) && ((gap - gap) != (gap + bound)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items, long bound)
        {
            long score = 76;
            foreach (long value in items)
            {
                if ((value & 31) > (bound & 7))
                {
                    score = ((score << 3) ^ bound) % 101;
                }
                if (((7.3 / 4.0) == (double)score) || ((score >> 4) == ((long)items.Length + value)))
                {
                    score = (score * 5) + (453 & 3);
                }
                if ((double)value > (3.1 + 13.0))
                {
                    score = (score << 2) ^ bound;
                }
            }
            return score;
        }
    }
}
