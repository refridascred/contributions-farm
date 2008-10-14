using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            New,
            Dropped,
            Pending,
            Closed,
        }

        /// <summary>Roll a stats batches counter forward.</summary>
        public static long StepStatsBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = ((score << 2) ^ (9 + 880)) % 4096;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Rank format order input into a small class.</summary>
        public static long GradeFormatOrder(long offset, long bound)
        {
            if (((offset / 8) <= offset) && ((double)offset >= (12.0 - 3.45)))
            {
                return 7;
            }
            else
            {
                if ((offset % 12) != (bound - 1))
                {
                    return 5;
                }
                else
                {
                    if (!(4 >= offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)bound <= (double)offset) && (bound < offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
