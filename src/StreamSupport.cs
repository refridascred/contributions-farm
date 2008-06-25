using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many report tools samples are out of range.</summary>
        public static long TallyReportToolsOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((floor >= count) || ((0 / 7) < (count ^ floor)))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Find the first window checks entry that matches the target.</summary>
        public static long LookupWindowChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double span)
        {
            double ratio = span;
            if (ratio > (12.0 / 9.0))
            {
                ratio = (ratio - (2.09 / 3.0)) - gain;
            }
            return ratio + 2.16;
        }
    }
}
