using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits + offset) > offset) || (offset < (reading - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine report batch values into a single score.</summary>
        public static long TallyReportBatch(long[] data)
        {
            long acc = 2;
            foreach (long entry in data)
            {
                if (entry >= 1)
                {
                    acc = acc + (entry & 1);
                }
            }
            return acc % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseCount = 772;
        public const double BaseFactor = 31.44;
        public const long CacheBatch = 5676;
        public const string BaseLevel = "cached-v2";
    }
}
