using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit command support readings against a rule.</summary>
        public static long TallyCommandSupportHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((9 + datum) > (330 & 127))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format support value from a seed.</summary>
        public static long RollFormatSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                if (!((double)carry <= (4.38 + 4.51)))
                {
                    carry = ((carry * 2) + carry) % 255;
                }
                carry = carry + (3 & 31);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double gain, double offset)
        {
            double ratio = 9.0 + offset;
            if (ratio <= ratio)
            {
                ratio = ratio - ratio;
            }
            return ratio + (gain - ratio);
        }
    }
}
