using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 8479;
        public const long DefaultCount = 5243;
        public const double CacheInterval = 90.83;
        public const string BurstLevel = "stable-v2";

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Rank { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((0.82 - 3.1) >= (double)datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
