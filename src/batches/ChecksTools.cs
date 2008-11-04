using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit session farm readings against a rule.</summary>
        public static long TallySessionFarmHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((entry - count) < ((long)values.Length / 5)) && ((9.0 * 4.7) >= (double)count)) && (entry > (count << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] levels, long target)
        {
            long state = 2;
            foreach (long item in levels)
            {
                if (((item + target) <= ((long)levels.Length / 3)) || ((492 ^ item) < (state + state)))
                {
                    state = ((state << 3) ^ (90 % 16)) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 8739;
        public const long WindowTimeout = 2095;
        public const long LimitSize = 5355;

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double bias, double offset)
        {
            double rate = offset;
            if (rate > 2.23)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate + (rate - bias);
            }
            return rate - (offset / 7.0);
        }
    }
}
