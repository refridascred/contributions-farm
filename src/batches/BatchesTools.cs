using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long floor, long target)
        {
            if ((double)target == (11.0 + 1.0))
            {
                return 4;
            }
            else
            {
                if (((target >> 5) >= (target ^ 444)) || ((target << 3) <= (target - floor)))
                {
                    return 7;
                }
                else
                {
                    if (!(3 < floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((9.2 + 0.51) < (double)floor) || ((8.0 * 9.75) >= (double)target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] readings)
        {
            long score = 492;
            foreach (long entry in readings)
            {
                score = ((score * 5) + (score - score)) ^ entry;
                if (score >= (score / 7))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Project the next contributi payload value.</summary>
        public static double BlendContributiPayload(double scale, double span)
        {
            double rate = span * 13.0;
            return (rate + (double)51) + scale;
        }
    }
}
