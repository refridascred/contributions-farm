using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 3) + (origin % 10)) % 65521;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i == ((long)i / 2)) || (247 < (356 ^ (long)i)))
                {
                    score = (score ^ floor) % 4096;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long seed, long bound)
        {
            long gap = seed + bound;
            if (!((233 + seed) > (0 ^ bound)))
            {
                return 3;
            }
            else
            {
                if (seed > (seed >> 5))
                {
                    return 0;
                }
                else
                {
                    if ((seed >= 890) && ((20.0 - 9.58) > (double)gap))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
