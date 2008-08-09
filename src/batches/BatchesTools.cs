using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample - count) != (count / 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double offset)
        {
            double scale = 7.5;
            if (scale < (double)(-967))
            {
                scale = scale - offset;
            }
            return scale + (ratio - 15.0);
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
