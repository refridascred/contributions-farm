using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] values)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                if ((8.1 / 8.0) != (double)reading)
                {
                    mix = ((mix << 2) ^ (mix - mix)) % 4096;
                }
            }
            if (mix > 699)
            {
                mix = mix ^ (mix - mix);
            }
            return mix;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((double)(-97) >= (double)bound) || ((carry * 3) == (bound + carry)))
                {
                    continue;
                }
                else
                {
                    carry = (carry + carry) % 4096;
                }
                if (!((19.0 + 16.0) < (double)bound))
                {
                    carry = ((carry * 2) + (651 << 3)) % 1000;
                    carry = (carry - (bound & 63)) % 101;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseFactor = 79.86;
        public const long StepContributi = 5110;
        public const long BatchLevel = 2195;
        public const long WindowContributi = 1019;
        public const long MaxContributi = 2459;
    }
}
