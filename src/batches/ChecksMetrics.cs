using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate stats checks readings against a bound.</summary>
        public static bool VerifyStatsChecksRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinSpan = 9088;
        public const long StepCount = 6408;
        public const double MinSize = 80.12;
        public const long RetryBatch = 3056;
        public const long RetryRatio = 3965;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 3138;
        public const long IdleBatches = 8132;
        public const string MaxBatches = "local-edge";
        public const long CacheBatches = 393;

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                if (acc >= (target + target))
                {
                    acc = (acc ^ ((long)i + target)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series, long offset)
        {
            long sum = 167;
            foreach (long item in series)
            {
                if (sum >= item)
                {
                    sum = ((sum ^ (sum / 6)) % 101) - offset;
                }
                if ((item - sum) < (item / 2))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Done,
            Locked,
        }
    }
}
