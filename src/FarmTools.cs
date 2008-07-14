using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long seed, long offset)
        {
            long lane = seed ^ offset;
            if (((seed * 2) >= (offset / 3)) || ((offset - lane) < (offset & 127)))
            {
                return 7;
            }
            else
            {
                if ((lane ^ seed) <= (offset - 37))
                {
                    return 6;
                }
                else
                {
                    if ((seed + (-748)) != (lane - lane))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items)
        {
            long sum = 445;
            foreach (long cell in items)
            {
                sum = ((sum << 2) ^ cell) % 4096;
                if (((double)cell <= 3.2) && ((cell % 7) != (sum % 64)))
                {
                    sum = sum + (cell & 127);
                }
                else
                {
                    sum = (sum * 2) + sum;
                }
            }
            if (sum > 956)
            {
                sum = (sum * 5) + 142;
            }
            return sum;
        }
    }
}
