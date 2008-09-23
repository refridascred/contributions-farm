using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseChecks = 32.8;
        public const long RetryScore = 7272;
        public const long HardWidth = 8586;
        public const long CacheChecks = 3763;

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 4452;
        public const long BatchContext = 3090;
        public const long SoftContext = 5486;
        public const long HardFactor = 6023;
        public const long LimitContext = 1956;
    }
}
