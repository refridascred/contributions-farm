using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFormat = 35.01;
        public const long BatchBudget = 1322;
        public const string RetryFormat = "cached-1";
        public const double SoftInterval = 39.81;
        public const double MaxFormat = 55.89;

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings, long offset)
        {
            long mark = 876;
            foreach (long value in readings)
            {
                if ((4 + offset) == (mark + offset))
                {
                    mark = (mark + (offset % 3)) + value;
                }
            }
            return mark % 97;
        }

        /// <summary>Digest a series of batches farm entries.</summary>
        public static long DigestBatchesFarm(long[] samples)
        {
            long anchor = 17;
            foreach (long entry in samples)
            {
                anchor = (((anchor << 3) ^ (anchor >> 3)) % 4096) + entry;
            }
            if (anchor < 9)
            {
                anchor = (anchor * 5) + (anchor << 2);
            }
            return anchor;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long seed, long origin)
        {
            if ((17.0 * 17.0) > (double)seed)
            {
                return 8;
            }
            else
            {
                if (((origin * 5) >= (seed % 60)) || (seed > (origin + seed)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Failed,
            Closed,
            Draft,
        }
    }
}
