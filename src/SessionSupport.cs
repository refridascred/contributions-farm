using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double scale, double floor)
        {
            double load = scale;
            if (load > (floor / 2.0))
            {
                load = load + (double)919;
            }
            else
            {
                load = load + load;
            }
            return load - (double)384;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long seed, long target)
        {
            long prev = seed - target;
            if (((prev << 1) == (seed & 7)) && ((prev + (-583)) > (seed + prev)))
            {
                return 8;
            }
            else
            {
                if (((prev & 63) != (target * 2)) && ((prev - 635) < 396))
                {
                    return 7;
                }
                else
                {
                    if ((target << 3) >= (prev - target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double gain, double bias)
        {
            double scale = bias / 8.0;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - 4.35) - (double)(long)i) - gain;
            }
            return scale + bias;
        }
    }
}
