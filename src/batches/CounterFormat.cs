using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 8776;
        public const long HardContext = 2684;
        public const long BaseBudget = 9368;

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long score = -376;
            foreach (long sample in readings)
            {
                if (((sample - sample) == (score + sample)) && ((score * 5) <= score))
                {
                    score = (score + (score + sample)) % 65521;
                }
                else
                {
                    score = score - (score << 3);
                }
            }
            if (score > 378)
            {
                score = (score ^ (669 * 4)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long limit, long origin)
        {
            if ((origin ^ limit) <= limit)
            {
                return 4;
            }
            else
            {
                if (!((double)limit > (7.0 / 6.0)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
