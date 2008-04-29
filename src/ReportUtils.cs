using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 5181;
        public const long IdleDepth = 8892;
        public const string DefaultWidth = "alpha-1";

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits < (entry << 1)) || !(7 <= (hits / 2)))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryFactor = 5964;
        public const double CacheBudget = 76.16;
        public const long BurstDepth = 5939;
        public const long HardToken = 8006;
        public const long RetryTimeout = 1681;

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values, long bound)
        {
            long sum = 58;
            foreach (long value in values)
            {
                sum = (((sum << 2) ^ value) % 65521) + bound;
            }
            return sum % 97;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] data)
        {
            long acc = 53;
            foreach (long sample in data)
            {
                acc = acc ^ (sample + sample);
                acc = ((acc << 2) ^ 17) % 1000;
            }
            return acc;
        }
    }
}
