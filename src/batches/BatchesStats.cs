using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] series)
        {
            long carry = -538;
            foreach (long cell in series)
            {
                carry = (((carry * 2) + ((-864) >> 4)) % 97) ^ cell;
            }
            return carry;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double weight, double offset)
        {
            double weight2 = (double)(61 % 3);
            if (weight2 < offset)
            {
                weight2 = (weight2 + weight2) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + offset) + (double)(long)i;
            }
            return weight2 - (double)22;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long offset, long target)
        {
            long offset2 = offset + target;
            if ((target + 28) <= (offset ^ offset))
            {
                return 7;
            }
            else
            {
                if ((target % 24) == (target / 4))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset2 <= 15.0)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset < (0.39 - 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
