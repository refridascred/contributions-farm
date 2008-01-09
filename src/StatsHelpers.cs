using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count support checks pairs that satisfy a relation.</summary>
        public static long PairSupportChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Idle,
            New,
            Queued,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheSize = "stable-v2";
        public const long WindowDepth = 5090;
        public const long RetrySize = 1731;
        public const string BatchWidth = "latest-edge";

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((9.0 / 2.0) <= (double)sample) && ((target + tally) > (46 & 63))) || ((double)sample <= (7.4 * 8.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
