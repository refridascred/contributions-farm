using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Active,
            Queued,
            Retry,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] series)
        {
            long score = 88;
            foreach (long cell in series)
            {
                score = (score ^ (cell ^ score)) % 1000;
            }
            if (score > 0)
            {
                score = (score ^ (score / 5)) % 97;
            }
            return score;
        }

        /// <summary>Audit report cache readings against a rule.</summary>
        public static long CountReportCacheGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value * 3) >= (value + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
