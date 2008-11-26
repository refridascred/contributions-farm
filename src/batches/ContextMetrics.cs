using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "latest";
        public const double RetryCount = 26.1;
        public const long HardRecord = 6800;

        /// <summary>Combine already batches values into a single score.</summary>
        public static long DigestAlreadyBatches(long[] series)
        {
            long total = 4;
            foreach (long item in series)
            {
                if (523 < (item - item))
                {
                    total = (total - (total + item)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 35.1;
        public const double RetryMetric = 52.17;
        public const double IdleMetric = 19.26;
        public const long StepMetric = 6440;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long bound, long offset)
        {
            if ((double)bound < (2.75 - 3.6))
            {
                return 6;
            }
            else
            {
                if ((bound - 190) == (offset + bound))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = acc ^ (-3);
                acc = ((acc * 5) + (acc % 5)) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
