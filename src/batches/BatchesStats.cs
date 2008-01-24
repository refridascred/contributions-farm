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

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] values, long seed)
        {
            long acc = -558;
            foreach (long sample in values)
            {
                if ((7.0 / 7.0) == (double)seed)
                {
                    continue;
                }
                if (acc <= (sample * 2))
                {
                    acc = acc + ((-53) / 4);
                }
                else
                {
                    acc = (acc - seed) % 101;
                }
                if ((double)seed > (double)sample)
                {
                    acc = acc + (71 >> 1);
                }
            }
            return acc;
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
