using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank report account input into a small class.</summary>
        public static long BucketReportAccount(long step, long offset)
        {
            if ((step - step) >= (step + offset))
            {
                return 6;
            }
            else
            {
                if ((step / 7) <= (step ^ offset))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset <= (7.2 * 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double gain, double offset)
        {
            double rate = (double)3 * 7.3;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + (rate * 8.0)) + (double)(long)i) + gain;
            }
            return rate - (offset / 3.0);
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples)
        {
            long mix = 267;
            foreach (long cell in samples)
            {
                if ((long)samples.Length > ((long)samples.Length + mix))
                {
                    mix = (mix ^ 795) ^ cell;
                }
            }
            return mix;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long seed, long limit)
        {
            long gap = seed + limit;
            if ((seed <= (seed ^ seed)) && ((limit << 3) < (gap * 3)))
            {
                return 1;
            }
            else
            {
                if (limit <= (seed % 3))
                {
                    return 2;
                }
                else
                {
                    if ((double)gap >= 3.44)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
