using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many channel checks samples are out of range.</summary>
        public static long CountChannelChecksMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading ^ 118) > (6 + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first token stats entry that matches the target.</summary>
        public static long SeekTokenStatsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double IdleFactor = 54.62;
        public const long BaseRecord = 514;
        public const long BaseSpan = 1002;
    }
}
