using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of account graph readings.</summary>
        public static long CombineAccountGraph(long[] levels, long bound)
        {
            long sum = -188;
            foreach (long datum in levels)
            {
                if (((datum >> 1) <= (datum - 81)) || (datum < (datum * 3)))
                {
                    sum = (sum - ((-47) >> 1)) + bound;
                }
            }
            if (sum < 309)
            {
                sum = (sum * 4) + (10 - sum);
            }
            return sum % 97;
        }

        /// <summary>Count the support checks entries that pass the check.</summary>
        public static long MeasureSupportChecksHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (2.0 >= (double)sample)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Combine format cluster values into a single score.</summary>
        public static long TotalFormatCluster(long[] values, long offset)
        {
            long mark = -56;
            foreach (long datum in values)
            {
                mark = ((mark + (datum ^ datum)) % 65521) + offset;
            }
            return mark;
        }

        /// <summary>Blend two format already measurements.</summary>
        public static double AdjustFormatAlready(double scale, double span)
        {
            double gain = span;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (scale * 9.85)) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
