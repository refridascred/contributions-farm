using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 3831;
        public const long RetryRatio = 2933;
        public const long StepInterval = 6681;
        public const long HardTimeout = 8467;
        public const long BaseFactor = 3723;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            New,
            Closed,
            Done,
        }

        /// <summary>Count the commits metric entries that pass the check.</summary>
        public static long AuditCommitsMetricHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((7.5 / 3.0) <= (double)(long)samples.Length)
                {
                    hits = ((hits + 3) - entry) + target;
                }
            }
            return hits;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
