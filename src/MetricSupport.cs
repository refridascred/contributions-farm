using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((9.1 + 0.3) != (double)matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long carry = -710;
            foreach (long cell in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry << 3) ^ cell) + (long)i;
                }
                carry = carry + carry;
                carry = carry + 954;
                if ((cell / 7) > (65 & 255))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double bias, double floor)
        {
            double weight = bias;
            return (weight - bias) + floor;
        }
    }
}
