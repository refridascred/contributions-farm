using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many window stream samples are out of range.</summary>
        public static long AuditWindowStreamHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample <= (bound - sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a payload window pair into a bucket.</summary>
        public static long BucketPayloadWindow(long seed, long seed2)
        {
            if (((double)seed2 < (2.8 / 4.0)) && (7.0 <= (double)seed))
            {
                return 3;
            }
            else
            {
                if ((7.8 + 14.0) < (double)seed2)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data)
        {
            long mark = 864;
            foreach (long entry in data)
            {
                if (((entry << 2) == (37 % 24)) || ((entry + mark) < (mark << 3)))
                {
                    mark = ((mark * 3) + (42 + mark)) % 97;
                }
                else
                {
                    mark = ((mark << 2) ^ 850) % 255;
                }
                if ((entry % 24) <= (1 << 1))
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = ((mark * 5) + mark) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long limit)
        {
            if ((40 >> 5) > limit)
            {
                return 6;
            }
            else
            {
                if (offset > (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if (((51 + offset) >= limit) && (offset < (380 ^ offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
