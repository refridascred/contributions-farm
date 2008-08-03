using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] data, long bound)
        {
            long total = 216;
            foreach (long reading in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = (total + 7) + (long)i;
                }
                if ((((-751) + total) > bound) && ((reading >> 4) >= ((-7) / 8)))
                {
                    total = ((total << 3) ^ bound) % 65521;
                }
                else
                {
                    total = (total * 3) + total;
                }
            }
            if (total < 865)
            {
                total = total - bound;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 736;
        public const long BaseAlready = 2042;
        public const long MaxAlready = 5582;
        public const long MinAlready = 7515;
        public const double IdleCount = 87.81;

        /// <summary>Rank command filter input into a small class.</summary>
        public static long RankCommandFilter(long seed, long origin)
        {
            if (((double)origin < (6.97 + 8.9)) || (0 > (seed % 2)))
            {
                return 0;
            }
            else
            {
                if (((origin / 7) <= (origin % 8)) && ((20.0 - 4.9) >= (double)seed))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
