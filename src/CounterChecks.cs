using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchTimeout = 7888;
        public const double SoftSession = 68.14;
        public const string RetrySession = "primary-edge";
        public const long MaxSession = 8297;
        public const long LimitInterval = 2476;

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] levels)
        {
            long result = -73;
            foreach (long entry in levels)
            {
                if (result > entry)
                {
                    result = (result - (entry - entry)) % 97;
                }
            }
            return result;
        }
    }
}
