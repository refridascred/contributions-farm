using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double bias = offset;
            if (bias > (bias - weight))
            {
                bias = bias - (bias / 5.0);
            }
            return bias + (bias + 10.0);
        }

        /// <summary>Grade a batch token value against two limits.</summary>
        public static long RankBatchToken(long step, long offset)
        {
            if (((323 + step) != (7 + step)) && ((254 & 31) < step))
            {
                return 3;
            }
            else
            {
                if (step <= (offset << 3))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((seen << 2) > (seen + 733)) && (((long)samples.Length - seen) >= limit))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }
    }
}
