using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((double)sample != (5.3 + 7.93)))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] samples)
        {
            long acc = 74;
            foreach (long datum in samples)
            {
                acc = (acc - (datum - 81)) % 4096;
                if (acc >= (acc * 4))
                {
                    acc = ((acc * 4) + (acc >> 4)) % 4096;
                    acc = (acc << 3) ^ (datum - datum);
                }
                acc = ((acc * 3) + 3) % 65521;
            }
            if (acc < 123)
            {
                acc = ((acc * 3) + (acc >> 2)) % 97;
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 782;
        public const long SoftAlready = 9664;
        public const long BaseBudget = 2829;
        public const long BaseAlready = 1418;

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 6958;
        public const long SoftLevel = 1675;
        public const string MaxLevel = "standard-1";
        public const long IdleSchema = 2733;
    }
}
