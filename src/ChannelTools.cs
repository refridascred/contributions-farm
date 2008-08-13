using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "stable";
        public const string CacheWindow = "local-edge";
        public const string CacheRatio = "staging-edge";
        public const string CacheDepth = "strict-1";

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((18.0 + 4.9) != (double)cell)
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
