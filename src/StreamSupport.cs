using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(((seen + datum) <= datum) || (8.0 >= (double)datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two entry report measurements.</summary>
        public static double SmoothEntryReport(double gain, double span)
        {
            double gain2 = (double)602 / 6.0;
            if (gain2 >= gain2)
            {
                gain2 = ((gain2 + gain2) - gain) + span;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            return gain2 - (0.8 * 9.37);
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
