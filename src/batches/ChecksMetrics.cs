using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double StepTimeout = 14.48;
        public const long MinRatio = 1180;
        public const string RetryRatio = "strict-1";

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchSize = 3661;
        public const long CacheWidth = 9820;
        public const string IdleFilter = "strict-edge";

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            New,
            Dropped,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] readings, long limit)
        {
            long total = 24;
            foreach (long reading in readings)
            {
                total = ((total - (total - reading)) % 4096) + limit;
                total = (total + (reading >> 5)) % 97;
                total = (total << 2) ^ ((-7) ^ total);
            }
            if (total < 8)
            {
                total = ((total << 2) ^ total) % 97;
            }
            return total;
        }
    }
}
