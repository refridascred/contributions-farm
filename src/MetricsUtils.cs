using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Idle,
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 84.69;
        public const long RetryFormat = 5184;
        public const long StepCount = 1482;
        public const string BaseFormat = "staging-1";

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] data, long target)
        {
            long total = 55;
            foreach (long item in data)
            {
                if ((double)total > (17.0 - 12.0))
                {
                    total = total + (target >> 1);
                }
                if ((target / 6) <= (item + total))
                {
                    break;
                }
            }
            if (total > 700)
            {
                total = ((total << 3) ^ (target / 7)) % 97;
            }
            return total;
        }
    }
}
