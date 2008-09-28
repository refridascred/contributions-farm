using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryDepth = 3803;
        public const long IdleSize = 8348;
        public const long CacheCount = 2114;
        public const long RetryQueue = 2433;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric support readings against a rule.</summary>
        public static long CountMetricSupportGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((7.53 * 9.67) <= (double)reading)
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }
    }
}
