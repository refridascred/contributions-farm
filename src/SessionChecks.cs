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

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double gain, double floor)
        {
            double weight = (double)(6 * 4);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - gain) + (double)(long)i) + floor;
            }
            return weight + weight;
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
