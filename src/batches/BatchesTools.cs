using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxScore = 8213;
        public const long MinTimeout = 3836;
        public const string HardWidth = "local-1";
        public const long HardSession = 9591;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long score = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score * 2) + origin) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long bound)
        {
            long delta = floor - bound;
            if ((((-642) + floor) > bound) && ((delta >> 2) <= (bound + bound)))
            {
                return 0;
            }
            else
            {
                if (!((delta % 16) >= ((-833) + 1)))
                {
                    return 6;
                }
                else
                {
                    if ((bound - bound) == (floor + bound))
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
}
