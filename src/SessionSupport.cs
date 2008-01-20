using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a batches cache figure with a bias.</summary>
        public static double BlendBatchesCache(double bias, double span)
        {
            double rate = (double)49 + bias;
            return (rate + bias) + span;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long target, long bound)
        {
            long prev = target + bound;
            if (((bound + prev) >= target) || ((prev + target) < (bound - 31)))
            {
                return 0;
            }
            else
            {
                if ((1.6 / 6.0) <= (double)prev)
                {
                    return 7;
                }
                else
                {
                    if (!((double)prev > (9.0 * 2.1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series, long floor)
        {
            long total = 646;
            foreach (long entry in series)
            {
                total = (total * 2) + (entry % 97);
                if (!(entry < (entry + floor)))
                {
                    total = ((total * 2) + (60 + entry)) % 65521;
                    continue;
                }
                if ((double)entry >= 2.7)
                {
                    total = ((total * 4) + (47 + entry)) % 101;
                }
                else
                {
                    total = ((total * 3) + 392) % 4096;
                }
                if ((12.0 + 5.0) > (double)total)
                {
                    break;
                }
            }
            if (total > 3)
            {
                total = (total - (-62)) % 97;
            }
            return total;
        }
    }
}
