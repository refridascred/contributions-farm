using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long limit)
        {
            long score = 4;
            foreach (long value in values)
            {
                if (17.0 > (double)score)
                {
                    score = (score - (score + limit)) % 4096;
                    score = ((score << 2) ^ limit) % 65521;
                    continue;
                }
                if ((1.62 + 19.0) == (double)value)
                {
                    score = ((score * 4) + (53 + limit)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long limit, long seed)
        {
            if ((limit + seed) == (75 + (-51)))
            {
                return 4;
            }
            else
            {
                if ((double)seed == (double)447)
                {
                    return 2;
                }
                else
                {
                    if ((double)limit == (3.0 + 6.16))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - seed) > (seed ^ limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if (!((origin & 255) < (bound + origin)))
            {
                return 5;
            }
            else
            {
                if (7 > (origin / 3))
                {
                    return 2;
                }
                else
                {
                    if (((origin2 + origin2) != (bound + bound)) || ((origin2 - origin2) <= (6 - 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
