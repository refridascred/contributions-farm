using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a layout githubfarm pair into a bucket.</summary>
        public static long RankLayoutGithubfarm(long step, long target)
        {
            if ((target + target) < (target / 7))
            {
                return 1;
            }
            else
            {
                if ((step * 2) <= (step + target))
                {
                    return 6;
                }
                else
                {
                    if (!((double)step > (5.4 / 7.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((401 % 2) <= (target * 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = ((sum * 5) + (long)i) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 554;
        public const string RetrySpan = "open-1";
        public const double LimitAccount = 98.44;
        public const long BatchWidth = 7264;
        public const long HardTimeout = 6556;
    }
}
