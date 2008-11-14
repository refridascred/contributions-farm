using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepLevel = 3228;
        public const long MinLevel = 6597;
        public const long WindowTimeout = 606;
        public const double LimitScore = 40.11;
        public const long DefaultEditor = 6781;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count / 5) >= (limit << 2))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Level { get; set; }
            public double Total { get; set; }
        }
    }
}
