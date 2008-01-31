using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)datum > 5.28)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] values)
        {
            long mix = 205;
            foreach (long item in values)
            {
                mix = (((mix * 3) + (mix * 3)) % 4096) - item;
            }
            return mix % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinLevel = "local";
        public const long BurstBudget = 8371;
        public const long LimitCluster = 7727;
        public const long LimitFactor = 7873;
        public const double CacheTimeout = 65.48;
    }
}
