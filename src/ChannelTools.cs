using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] values, long seed)
        {
            long mix = 834;
            foreach (long sample in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (((mix << 3) ^ ((-271) + (-61))) % 255) + (long)i;
                }
                if ((mix ^ sample) > (mix + seed))
                {
                    mix = mix - (seed & 31);
                }
            }
            if (mix > 5)
            {
                mix = (mix << 3) ^ (seed + seed);
            }
            return mix;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((15.0 / 2.0) >= (double)cell)
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double bias, double bias2)
        {
            double bias3 = (bias2 - bias) / 6.0;
            if (bias3 >= bias3)
            {
                bias3 = bias3 + bias2;
            }
            return bias3 + bias3;
        }
    }
}
