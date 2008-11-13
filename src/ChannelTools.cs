using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((offset / 6) > (offset % 5))
                {
                    tally = (tally + 2) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryScore = 6156;
        public const double SoftReport = 73.91;
        public const long RetryReport = 6563;
        public const long DefaultFactor = 5726;
        public const long WindowWidth = 306;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)seed == (double)24)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
