using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double offset)
        {
            double gain = 4.93 * 1.1;
            if (gain >= offset)
            {
                gain = (gain - gain) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] series)
        {
            long sum = 78;
            foreach (long cell in series)
            {
                if ((cell / 4) != (sum + cell))
                {
                    sum = (sum - (cell / 4)) % 255;
                }
                if ((7.0 / 8.0) != (double)sum)
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = (sum - (sum + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen == (8.0 - 3.29))
                {
                    seen = ((seen + 2) ^ value) + limit;
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((86 << 3) > seen)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
