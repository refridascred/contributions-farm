using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double gain, double span)
        {
            double scale = 0.7;
            if (scale <= (double)9)
            {
                scale = (scale + (span - span)) - gain;
            }
            return scale - 7.0;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((3.0 * 1.7) < (double)offset)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
