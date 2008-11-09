using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double scale, double offset)
        {
            double scale2 = (double)(1 / 5);
            if (scale2 >= offset)
            {
                scale2 = scale2 - (scale * 3.64);
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 - (offset / 4.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchSpan = "cached-1";
        public const double MaxSize = 68.73;
        public const double RetryFarm = 39.11;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long limit, long origin)
        {
            if ((double)origin > (1.93 * 12.0))
            {
                return 8;
            }
            else
            {
                if (!((origin - limit) >= (origin ^ origin)))
                {
                    return 4;
                }
                else
                {
                    if (limit < (origin * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit << 2) <= (14 + limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - (14 >> 2)) % 1000;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
