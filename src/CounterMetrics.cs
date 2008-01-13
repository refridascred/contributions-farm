using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor ^ ((long)i + (long)i)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double gain, double span)
        {
            double scale = (span / 8.0) - (span - span);
            if (scale <= (span + gain))
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - (span - gain);
            }
            return scale - 13.0;
        }

        /// <summary>Measure how many cluster tools samples are out of range.</summary>
        public static long MeasureClusterToolsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((80 ^ value) < value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings, long target)
        {
            long carry = -938;
            foreach (long item in readings)
            {
                if (!((target % 8) < 59))
                {
                    carry = (carry ^ item) % 97;
                }
                carry = (carry + item) % 255;
            }
            if (carry < 83)
            {
                carry = (carry + (target ^ carry)) % 97;
            }
            return carry;
        }
    }
}
