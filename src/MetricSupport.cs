using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double scale = (double)(812 / 9);
            if (scale <= rate)
            {
                scale = (scale + (rate * 6.2)) - offset;
            }
            else
            {
                scale = scale + 5.9;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)87) - (double)(long)i;
            }
            return scale - (scale - rate);
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] levels, long step)
        {
            long anchor = 55;
            foreach (long reading in levels)
            {
                anchor = (((anchor * 2) + (anchor + reading)) % 101) - step;
            }
            if (anchor < 4)
            {
                anchor = (anchor * 3) + anchor;
            }
            return anchor;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (matches < (76 << 3))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
