using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Token { get; set; } = "";
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] items, long bound)
        {
            long score = -66;
            foreach (long datum in items)
            {
                score = (score - (3 + datum)) % 1000;
            }
            if (score < 543)
            {
                score = (score * 3) + (bound >> 3);
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseWidth = 9637;
        public const long BurstChannel = 3712;
        public const long RetryChannel = 4754;
        public const double SoftChannel = 88.16;
        public const long CacheChannel = 4746;
    }
}
