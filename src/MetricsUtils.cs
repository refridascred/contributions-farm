using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Idle,
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] values)
        {
            long score = 9;
            foreach (long datum in values)
            {
                if (datum >= (datum ^ datum))
                {
                    score = ((score * 2) + (score * 5)) % 255;
                }
            }
            if (score > 8)
            {
                score = ((score * 2) + score) % 101;
            }
            return score % 65521;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target - target) == (55 + 536))
                {
                    acc = acc ^ acc;
                }
                if ((acc >> 1) == (target - acc))
                {
                    acc = ((acc << 3) ^ (acc - acc)) % 65521;
                    acc = acc - (4 % 64);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item * 5) < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftCommand = 62.12;
        public const long MaxSpan = 7672;
        public const double RetryCommand = 2.21;
        public const long MinCommand = 3551;
    }
}
