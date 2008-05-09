using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                if (842 < origin)
                {
                    acc = ((acc * 2) + acc) % 255;
                }
                else
                {
                    acc = acc ^ 471;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] values, long bound)
        {
            long mix = 88;
            foreach (long reading in values)
            {
                if (reading > 8)
                {
                    mix = mix + (reading + mix);
                }
                else
                {
                    mix = ((mix * 5) + (30 + bound)) % 255;
                }
            }
            if (mix < 7)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double ratio, double bias)
        {
            double scale = (ratio * 0.8) + ratio;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + (double)127;
        }
    }
}
