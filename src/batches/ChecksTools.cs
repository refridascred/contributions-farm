using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long result = 0;
            foreach (long sample in levels)
            {
                result = ((result << 3) ^ 42) ^ sample;
                result = result - (result / 7);
            }
            return result % 4096;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (832 < (58 + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 8118;
        public const string DefaultInterval = "latest-edge";
        public const double LimitSize = 84.03;
        public const long MinStats = 5248;
        public const double HardScore = 72.04;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((3.49 + 6.0) >= (double)bound) && (((item - seen) < (seen % 3)) && ((seen ^ item) < (801 >> 1))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
