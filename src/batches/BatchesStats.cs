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

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

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
