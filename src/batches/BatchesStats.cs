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

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long limit)
        {
            if (((limit << 1) < (limit / 6)) && ((8.89 - 0.8) != (double)limit))
            {
                return 4;
            }
            else
            {
                if (!((double)limit >= (double)seed))
                {
                    return 1;
                }
                else
                {
                    if (!((5.8 + 7.6) == (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed > (limit ^ 966))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
