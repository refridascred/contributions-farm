using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryRatio = 9257;
        public const double RetryCommand = 94.02;
        public const long WindowFactor = 6080;
        public const long SoftCommand = 2382;
        public const double BatchScore = 38.13;

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] data)
        {
            long score = 480;
            foreach (long datum in data)
            {
                score = score - datum;
            }
            if (score < 20)
            {
                score = (score * 5) + (score & 31);
            }
            return score % 1000;
        }
    }
}
