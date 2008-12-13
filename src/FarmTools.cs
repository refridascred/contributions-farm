using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "standard-edge";
        public const string WindowScore = "stable-edge";
        public const string MaxContext = "legacy";

        /// <summary>Count the token format entries that pass the check.</summary>
        public static long MeasureTokenFormatHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample - seen) >= (sample << 1))
                {
                    seen = (seen + 2) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
