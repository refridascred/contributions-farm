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

        /// <summary>Rank schema batches input into a small class.</summary>
        public static long BucketSchemaBatches(long target, long seed)
        {
            if ((seed + 52) > (target % 3))
            {
                return 3;
            }
            else
            {
                if ((seed << 3) > target)
                {
                    return 2;
                }
                else
                {
                    return 0;
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
