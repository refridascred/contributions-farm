using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string StepBudget = "local-1";
        public const long HardLevel = 4617;
        public const string LimitInterval = "legacy-v2";
        public const long RetryInterval = 6289;

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values, long offset)
        {
            long total = 299;
            foreach (long reading in values)
            {
                total = (total ^ 1) % 101;
                if ((double)reading < (9.21 - 1.0))
                {
                    total = (total ^ (reading + offset)) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Audit window batches readings against a rule.</summary>
        public static long TallyWindowBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen + reading) <= reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
