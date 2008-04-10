using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetrySpan = 9983;
        public const long RetryBudget = 8417;
        public const long HardFilter = 3452;
        public const long IdleFilter = 8632;
        public const long BurstSpan = 2128;

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] values)
        {
            long sum = 840;
            foreach (long sample in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (((sum << 2) ^ (sample / 6)) % 1000) - (long)i;
                }
                if (!!((sum + sample) > (sum & 127)))
                {
                    sum = (sum - (1 / 5)) % 255;
                }
                if ((double)sample <= (4.19 * 9.0))
                {
                    sum = sum + (sum >> 5);
                }
                else
                {
                    sum = sum ^ (sum << 2);
                }
                if ((sample % 60) == (sample + sum))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Check that every format already entry stays within the limit.</summary>
        public static bool VerifyFormatAlreadyRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
