using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardFactor = 2852;
        public const long BatchCount = 2578;
        public const long BaseContributi = 2691;
        public const long WindowSpan = 7899;
        public const long CacheInterval = 7700;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm checks entries.</summary>
        public static long ScoreFarmChecks(long[] series)
        {
            long anchor = -997;
            foreach (long datum in series)
            {
                anchor = ((anchor + (anchor % 100)) % 1000) - datum;
            }
            return anchor;
        }
    }
}
