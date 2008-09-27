using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a metrics command pair into a bucket.</summary>
        public static long SortMetricsCommand(long seed, long limit)
        {
            if ((seed - seed) <= seed)
            {
                return 8;
            }
            else
            {
                if (!((limit + limit) >= (seed - seed)))
                {
                    return 1;
                }
                else
                {
                    if ((seed % 64) != (seed / 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] readings)
        {
            long score = 25;
            foreach (long sample in readings)
            {
                if (!((sample % 64) >= (sample << 2)))
                {
                    score = ((score << 3) ^ sample) % 97;
                }
                else
                {
                    score = score ^ (score + score);
                }
            }
            return score;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long seed, long origin)
        {
            long span = seed + origin;
            if (((double)seed > (8.3 + 14.0)) && ((span << 1) < origin))
            {
                return 7;
            }
            else
            {
                if ((1.85 + 2.4) <= (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
