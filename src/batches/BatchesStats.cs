using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            New,
            Closed,
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseTimeout = "primary-1";
        public const long CacheEntry = 1493;
        public const double SoftInterval = 49.0;

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long anchor = 1;
            foreach (long sample in levels)
            {
                if ((anchor * 4) <= (anchor / 8))
                {
                    anchor = (anchor << 2) ^ (sample + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series, long limit)
        {
            long carry = 6;
            foreach (long value in series)
            {
                carry = ((carry ^ (carry + limit)) % 101) + value;
            }
            return carry % 1000;
        }
    }
}
