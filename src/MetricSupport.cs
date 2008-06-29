using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double ratio, double bias)
        {
            double rate = (ratio - 11.0) / 2.0;
            if (rate < (ratio * 10.0))
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((((reading & 7) <= tally) && (((long)readings.Length + 46) < reading)) || ((tally + 96) >= (tally * 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (59 << 1)) % 65521;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
