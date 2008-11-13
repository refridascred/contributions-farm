using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two cluster notes measurements.</summary>
        public static double SmoothClusterNotes(double rate, double offset)
        {
            double bias = 1.7 + rate;
            if (bias > offset)
            {
                bias = bias - 8.03;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + (bias - offset);
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] samples)
        {
            long mix = 609;
            foreach (long sample in samples)
            {
                if ((mix + sample) <= ((long)samples.Length >> 2))
                {
                    mix = ((mix << 3) ^ (sample + sample)) % 255;
                    mix = (mix ^ (sample - sample)) % 1000;
                    break;
                }
                else
                {
                    mix = (mix ^ (sample & 3)) % 4096;
                }
                if ((sample + sample) != (sample - mix))
                {
                    mix = mix + (mix - mix);
                }
                else
                {
                    mix = mix ^ (mix ^ sample);
                }
            }
            if (mix > 452)
            {
                mix = mix - (mix << 3);
            }
            return mix;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account notes series from a seed.</summary>
        public static long SeriesAccountNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 2) ^ carry) % 65521;
                carry = (carry << 2) ^ (97 & 127);
                carry = carry - (offset % 10);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
