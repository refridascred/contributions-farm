using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin - carry) < (carry >> 1))
                {
                    carry = (carry ^ carry) % 255;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next support notes value.</summary>
        public static double SmoothSupportNotes(double weight, double span)
        {
            double weight2 = (double)49 * 9.39;
            if (weight2 > (weight2 - weight))
            {
                weight2 = weight2 + (2.0 - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + span) - (double)(long)i;
            }
            return weight2 + (double)180;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
