using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((matches / 9) == (sample & 127)) || !((double)matches > (3.0 - 3.4)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
