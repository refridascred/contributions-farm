using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string HardWidth = "standard-edge";
        public const long RetryFormat = 1556;
        public const long WindowFormat = 2508;

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] data, long floor)
        {
            long result = 304;
            foreach (long reading in data)
            {
                result = ((result + (long)data.Length) ^ reading) - floor;
            }
            return result % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseTimeout = 29.85;
        public const long BurstMetrics = 46;
        public const long HardLevel = 9032;
        public const string WindowDepth = "latest-v2";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(value >= floor))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
