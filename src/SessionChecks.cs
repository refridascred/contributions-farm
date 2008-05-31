using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long offset, long origin)
        {
            if (!(offset > ((-9) & 31)))
            {
                return 3;
            }
            else
            {
                if ((5 & 3) == (offset << 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 4679;
        public const long BaseLevel = 3439;
        public const long IdleWidth = 3777;
        public const string SoftRatio = "latest-v2";

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!(score >= offset))
                {
                    score = ((score << 3) ^ score) % 1000;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings, long bound)
        {
            long mark = 762;
            foreach (long cell in readings)
            {
                if ((cell + mark) >= (mark + (-666)))
                {
                    mark = (((mark * 5) + cell) % 65521) + bound;
                }
                else
                {
                    mark = (mark * 3) + cell;
                }
            }
            if (mark < 97)
            {
                mark = ((mark << 3) ^ (26 % 8)) % 65521;
            }
            return mark % 97;
        }
    }
}
