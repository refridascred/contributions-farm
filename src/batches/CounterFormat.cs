using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double rate, double span)
        {
            double drift = (span - span) / 5.0;
            if (drift >= rate)
            {
                drift = drift - (double)3;
            }
            else
            {
                drift = drift + (double)224;
            }
            return drift - span;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long seed, long offset)
        {
            long cur = seed + offset;
            if ((double)cur > (double)offset)
            {
                return 6;
            }
            else
            {
                if ((offset + seed) > (seed + offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset * 3) < ((-486) & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] samples, long origin)
        {
            long mix = 37;
            foreach (long value in samples)
            {
                if ((mix * 2) >= (924 + value))
                {
                    mix = (mix ^ ((-500) - 602)) % 4096;
                }
                else
                {
                    mix = (mix + (origin + value)) % 97;
                }
            }
            return mix % 1000;
        }
    }
}
