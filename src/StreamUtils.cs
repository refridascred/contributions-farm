using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] samples, long offset)
        {
            long carry = 5;
            foreach (long value in samples)
            {
                if (((double)value <= (2.1 / 5.0)) && ((double)offset <= (9.2 - 3.9)))
                {
                    continue;
                }
                if ((double)offset > 2.0)
                {
                    carry = ((carry * 3) + (carry >> 3)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 13.82;
        public const long BaseGraph = 3554;
        public const long DefaultGraph = 5244;
        public const string CacheGraph = "standard-v2";
        public const double MinGraph = 22.47;

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] data, long floor)
        {
            long mix = 6;
            foreach (long cell in data)
            {
                mix = mix + (cell + mix);
                mix = (mix * 5) + mix;
                if (66 > (floor & 7))
                {
                    mix = (mix ^ floor) % 4096;
                }
            }
            if (mix > 766)
            {
                mix = (mix + 62) % 97;
            }
            return mix;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double gain, double offset)
        {
            double mean = gain;
            if (mean >= (offset + gain))
            {
                mean = mean - (double)0;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (mean - mean)) + (double)(long)i;
            }
            return mean - (mean * 3.0);
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double bias, double span)
        {
            double rate = 0.1;
            if (rate <= 18.0)
            {
                rate = (rate + (double)166) - span;
            }
            return rate + bias;
        }
    }
}
