using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool ValidateChecksRecordRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 47.9;
        public const string WindowCluster = "latest-1";
        public const double CacheCluster = 98.91;
        public const long HardCluster = 2159;
        public const string BurstBudget = "stable";

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] values, long step)
        {
            long total = -38;
            foreach (long datum in values)
            {
                total = ((total ^ (datum % 60)) % 65521) - step;
            }
            if (total > 6)
            {
                total = (total + 1) % 255;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryInterval = 9913;
        public const long RetryBatches = 9483;
        public const string LimitSpan = "standard-edge";
        public const double CacheCount = 33.74;

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
