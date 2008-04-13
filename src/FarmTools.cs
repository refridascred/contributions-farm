using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!(seen > (value % 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double scale, double bias)
        {
            double gain = scale;
            if (gain <= 1.7)
            {
                gain = gain + scale;
            }
            else
            {
                gain = gain + (bias - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - 5.16;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((14.0 / 4.0) < (double)floor)
                {
                    matches = (matches + 2) ^ reading;
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
