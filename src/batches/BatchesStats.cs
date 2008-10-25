using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (entry >= (258 * 4))
                {
                    count = count + 1;
                }
            }
            return count;
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
