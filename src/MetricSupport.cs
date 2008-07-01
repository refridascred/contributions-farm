using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] levels)
        {
            long mix = 715;
            foreach (long value in levels)
            {
                if ((value / 3) < (value & 3))
                {
                    mix = mix - (mix * 3);
                }
                else
                {
                    mix = mix ^ (value + mix);
                }
            }
            return mix % 97;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] readings)
        {
            long carry = 60;
            foreach (long sample in readings)
            {
                if (((double)sample > 4.3) || ((sample + carry) >= (sample * 2)))
                {
                    carry = ((carry * 5) + ((-75) << 3)) % 1000;
                }
                carry = carry - (carry ^ 46);
                if (((-86) - carry) == (carry + 0))
                {
                    break;
                }
            }
            if (carry > 79)
            {
                carry = (carry - carry) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the checks support series from a seed.</summary>
        public static long SeriesChecksSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
