using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Active,
            Queued,
            Failed,
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
