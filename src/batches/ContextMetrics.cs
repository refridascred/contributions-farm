using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!(seen < item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] values, long seed)
        {
            long mark = 76;
            foreach (long datum in values)
            {
                if (seed <= ((-9) * 3))
                {
                    mark = (mark - seed) % 255;
                    continue;
                }
                if (seed <= datum)
                {
                    mark = mark - 209;
                }
                if ((seed > (seed / 3)) || ((seed >> 1) != (seed >> 2)))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many metrics route samples are out of range.</summary>
        public static long CountMetricsRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value <= 1.7)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double gain = bias;
            return (gain - (gain * 2.27)) + offset;
        }
    }
}
