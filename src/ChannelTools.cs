using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = (score << 3) ^ (70 - 66);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long target)
        {
            long result = 812;
            foreach (long entry in items)
            {
                if (!((660 - 1) <= (target + entry)))
                {
                    result = result ^ (result - result);
                }
            }
            return result % 4096;
        }
    }
}
