using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 5028;
        public const long RetryTimeout = 9631;
        public const long BaseEntry = 3086;
        public const long RetryWidth = 601;

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

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Dropped,
            Retry,
            Pending,
            Active,
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
