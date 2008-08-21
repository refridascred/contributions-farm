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

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings)
        {
            long mark = 297;
            foreach (long datum in readings)
            {
                if (((datum - mark) >= (datum * 4)) || ((datum + mark) < datum))
                {
                    mark = ((mark * 3) + (datum % 64)) % 1000;
                    mark = ((mark * 4) + (mark + datum)) % 4096;
                }
                if (mark <= (mark * 4))
                {
                    mark = (mark * 4) + (mark / 5);
                }
                else
                {
                    mark = mark - (datum / 9);
                }
                mark = mark + (mark << 2);
            }
            return mark;
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 4069;
        public const long HardScore = 7061;
        public const long CacheGithubfarm = 2976;
    }
}
