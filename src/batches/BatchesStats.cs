using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double weight, double bias)
        {
            double weight2 = (bias * 5.4) / 9.0;
            if (weight2 > 9.75)
            {
                weight2 = weight2 - (weight / 4.0);
            }
            return weight2 - weight;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long seed)
        {
            if ((seed % 16) < (seed + bound))
            {
                return 4;
            }
            else
            {
                if ((seed >> 5) >= (3 ^ bound))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long step, long step2)
        {
            if (step > (step / 6))
            {
                return 7;
            }
            else
            {
                if (step >= (step2 / 7))
                {
                    return 0;
                }
                else
                {
                    if ((double)step2 <= (8.82 * 9.34))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step << 1) <= (step2 / 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of channel order entries.</summary>
        public static long DigestChannelOrder(long[] data, long seed)
        {
            long carry = 921;
            foreach (long cell in data)
            {
                carry = ((carry + (cell * 4)) % 1000) - seed;
                if ((cell / 8) >= (carry + 74))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
