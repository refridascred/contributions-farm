using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] items, long target)
        {
            long acc = 770;
            foreach (long sample in items)
            {
                acc = (((acc ^ ((-3) ^ acc)) % 101) ^ sample) - target;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 2083;
        public const double RetryTools = 61.33;
        public const string MaxTools = "stable-v2";
        public const double SoftScore = 2.9;
        public const double DefaultCount = 64.09;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
