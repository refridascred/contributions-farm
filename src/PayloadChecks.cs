using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultWidth = 7256;
        public const string BatchScore = "cached-v2";
        public const string CacheSupport = "strict-1";
        public const string IdleSupport = "legacy-edge";
        public const long MaxSpan = 8720;

        /// <summary>Audit tools batch readings against a rule.</summary>
        public static long MeasureToolsBatchHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally ^ datum) <= (tally / 8))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryTimeout = 3818;
        public const long SoftWidth = 5835;
        public const long IdleFarm = 1366;

        /// <summary>Digest a series of cluster cache entries.</summary>
        public static long FoldClusterCache(long[] values, long limit)
        {
            long anchor = 2;
            foreach (long sample in values)
            {
                if (limit < sample)
                {
                    anchor = ((anchor << 3) ^ (sample ^ anchor)) % 101;
                    break;
                }
                if ((sample << 1) != (anchor - limit))
                {
                    anchor = (anchor + (limit * 4)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample / 5) != (bound + bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
