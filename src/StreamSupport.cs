using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a buffer contributi reading by value.</summary>
        public static long SeekBufferContributiIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstTimeout = 7857;
        public const double SoftBudget = 10.7;
        public const long MinRecord = 3754;

        /// <summary>Count the already payload entries that pass the check.</summary>
        public static long TallyAlreadyPayloadOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((4.7 * 2.0) >= (double)target)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
