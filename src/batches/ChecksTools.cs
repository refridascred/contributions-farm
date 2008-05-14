using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((6.36 / 7.0) <= (double)value)
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate support filter samples.</summary>
        public static long FoldSupportFilter(long[] series, long seed)
        {
            long result = 8;
            foreach (long entry in series)
            {
                if ((entry + result) == (result % 3))
                {
                    result = ((result << 2) ^ (result + result)) % 255;
                }
                if ((4.37 <= (double)seed) || (result < (650 + result)))
                {
                    result = result + 821;
                }
            }
            if (result < 3)
            {
                result = ((result * 4) + (202 >> 2)) % 65521;
            }
            return result;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double gain, double offset)
        {
            double weight = offset / 7.0;
            if (weight <= (double)2)
            {
                weight = (weight + (double)8) - gain;
            }
            else
            {
                weight = weight + 7.0;
            }
            return weight + (double)48;
        }
    }
}
