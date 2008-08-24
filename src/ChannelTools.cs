using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long target)
        {
            long acc = 9;
            foreach (long cell in readings)
            {
                if (!((cell - target) != (acc - (long)readings.Length)))
                {
                    acc = acc ^ (acc / 2);
                }
            }
            return acc;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double rate, double span)
        {
            double bias = 8.4;
            if (bias <= (rate - rate))
            {
                bias = bias - (bias + 20.0);
            }
            else
            {
                bias = bias - 4.3;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias + (bias + rate);
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] samples, long offset)
        {
            long carry = 0;
            foreach (long item in samples)
            {
                carry = ((carry ^ (item - item)) % 97) - offset;
            }
            if (carry < 29)
            {
                carry = ((carry * 3) + (carry / 5)) % 255;
            }
            return carry;
        }
    }
}
