using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi stream counter forward.</summary>
        public static long StepContributiStream(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] series, long floor)
        {
            long state = 882;
            foreach (long datum in series)
            {
                if ((2.2 / 6.0) < (double)floor)
                {
                    state = (((state * 3) + floor) % 101) + datum;
                }
            }
            return state;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double gain, double floor)
        {
            double ratio = gain * 6.6;
            return (ratio - (ratio * 5.2)) + floor;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] series)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                mix = ((mix << 2) ^ cell) % 97;
                mix = mix + (mix + 91);
                if ((mix - mix) < (mix << 3))
                {
                    mix = ((mix << 2) ^ (cell & 127)) % 101;
                }
                if ((double)cell != (4.02 - 9.13))
                {
                    break;
                }
            }
            if (mix > 37)
            {
                mix = (mix * 2) + mix;
            }
            return mix;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double scale, double bias)
        {
            double scale2 = (double)((-41) ^ 53);
            if (scale2 >= (1.0 * 3.3))
            {
                scale2 = scale2 - (double)4;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (bias / 3.0)) + (double)(long)i;
            }
            return scale2 - (scale * 0.29);
        }
    }
}
