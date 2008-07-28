using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long target, long offset)
        {
            if (offset < (-6))
            {
                return 6;
            }
            else
            {
                if ((offset - offset) == (offset % 5))
                {
                    return 0;
                }
                else
                {
                    if (7 <= (offset * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((target & 31) < (2 / 2)))
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

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double ratio, double span)
        {
            double bias = 9.0;
            if (bias < 9.3)
            {
                bias = (bias + bias) - span;
            }
            else
            {
                bias = bias + (ratio - ratio);
            }
            return bias + bias;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] levels)
        {
            long score = 430;
            foreach (long datum in levels)
            {
                if ((5.2 * 7.0) <= (double)datum)
                {
                    score = (score << 3) ^ (score << 1);
                }
            }
            return score;
        }
    }
}
